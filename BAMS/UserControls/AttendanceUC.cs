using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using PdfColor = QuestPDF.Helpers.Colors;
using BAMS.Repositories;

namespace BAMS.UserControls
{
    public partial class AttendanceUC : UserControl
    {
        public AttendanceUC()
        {
            InitializeComponent();

            dtFrom.Value = DateTime.Today.AddDays(-7);
            dtTo.Value = DateTime.Today;

            InitializeEmployeeCombo();
            StyleGrid();
            LoadAttendance();
        }

        private void InitializeEmployeeCombo()
        {
            cmbEmployee.Items.Clear();

            cmbEmployee.Items.AddRange(new object[]
            {
                "All",
                "Admin",
                "Official",
                "Staff"
            });

            cmbEmployee.SelectedIndex = 0;
        }

        private void StyleGrid()
        {
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.EnableHeadersVisualStyles = false;

            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.RoyalBlue; // fully qualified
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White; // fully qualified
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAttendance.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvAttendance.RowTemplate.Height = 35;

            dgvAttendance.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240); // fully qualified

            dgvAttendance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAttendance.MultiSelect = false;
        }

        private void txtSearchName_TextChanged(object? sender, EventArgs e)
            => LoadAttendance();

        private void dtFrom_ValueChanged(object? sender, EventArgs e)
            => LoadAttendance();

        private void dtTo_ValueChanged(object? sender, EventArgs e)
            => LoadAttendance();

        private void cmbEmployee_SelectedIndexChanged(object? sender, EventArgs e)
            => LoadAttendance();

        private void btnFilter_Click(object? sender, EventArgs e)
            => LoadAttendance();

        private void AttendanceUC_Load(object? sender, EventArgs e)
        {
        }

        private void label4_Click(object? sender, EventArgs e)
        {
        }

        private void dgvAttendance_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExportPdf_Click(object? sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No attendance data to export.");
                return;
            }

            using SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Attendance_Report.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                QuestPDF.Settings.License = LicenseType.Community;

                string filePath = saveFileDialog.FileName;

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(20);

                        page.Header().Column(column =>
                        {
                            column.Item().Text("Attendance Report")
                                .FontSize(20)
                                .SemiBold()
                                .AlignCenter();

                            column.Item().Text(
                                $"From: {dtFrom.Value:MM/dd/yyyy}  To: {dtTo.Value:MM/dd/yyyy}")
                                .FontSize(12)
                                .AlignCenter();
                        });

                        page.Content().PaddingVertical(10).Table(table =>
                        {
                            int columnCount = dgvAttendance.Columns.Count;

                            table.ColumnsDefinition(columns =>
                            {
                                for (int i = 0; i < columnCount; i++)
                                    columns.RelativeColumn();
                            });

                            // Header row
                            table.Header(header =>
                            {
                                foreach (DataGridViewColumn column in dgvAttendance.Columns)
                                {
                                    header.Cell()
                                        .Border(1)
                                        .Background(PdfColor.Grey.Lighten2)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(column.HeaderText)
                                        .SemiBold();
                                }
                            });

                            // Data rows
                            foreach (DataGridViewRow row in dgvAttendance.Rows)
                            {
                                if (row.IsNewRow) continue;

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.Cell()
                                        .Border(1)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(cell.Value?.ToString() ?? "");
                                }
                            }
                        });
                    });
                })
                .GeneratePdf(filePath);

                MessageBox.Show("PDF exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void LoadAttendance()
        {
            try
            {
                AttendanceRepository repo = new AttendanceRepository();

                string name = txtSearchName.Text?.Trim() ?? string.Empty;
                string role = cmbEmployee.SelectedItem?.ToString() ?? "All";

                DataTable dt = repo.GetAttendanceLogs(
                    dtFrom.Value,
                    dtTo.Value,
                    name,
                    role
                );

                dgvAttendance.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    TimeSpan? amIn = row["AM_In"] == DBNull.Value ? null : (TimeSpan?)row["AM_In"];
                    TimeSpan? amOut = row["AM_Out"] == DBNull.Value ? null : (TimeSpan?)row["AM_Out"];
                    TimeSpan? pmIn = row["PM_In"] == DBNull.Value ? null : (TimeSpan?)row["PM_In"];
                    TimeSpan? pmOut = row["PM_Out"] == DBNull.Value ? null : (TimeSpan?)row["PM_Out"];

                    double totalHours = 0;

                    if (amIn.HasValue && amOut.HasValue)
                        totalHours += (amOut.Value - amIn.Value).TotalHours;

                    if (pmIn.HasValue && pmOut.HasValue)
                        totalHours += (pmOut.Value - pmIn.Value).TotalHours;

                    double undertime = totalHours < 8 ? 8 - totalHours : 0;
                    double overtime = totalHours > 8 ? totalHours - 8 : 0;

                    repo.UpdateComputedHours(
                        Convert.ToInt32(row["AttendanceId"]),
                        undertime,
                        overtime,
                        totalHours
                    );

                    dgvAttendance.Rows.Add(
                        row["AttendanceId"] ?? 0,
                        row["FullName"]?.ToString() ?? "",
                        Convert.ToDateTime(row["Day"]).ToShortDateString(),
                        amIn?.ToString(@"hh\:mm") ?? "",
                        amOut?.ToString(@"hh\:mm") ?? "",
                        pmIn?.ToString(@"hh\:mm") ?? "",
                        pmOut?.ToString(@"hh\:mm") ?? "",
                        undertime.ToString("0.00"),
                        overtime.ToString("0.00"),
                        totalHours.ToString("0.00"),
                        row["Remarks"]?.ToString() ?? ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}