using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Helper
{
    public class Helper
    {
        public static void ImportExcel (ref DataTable data)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "excel file |*.xls;*.xlsx";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = false;
            fileDialog.Title = "Chọn file excel";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = fileDialog.FileName;
                try
                {
                    // mở file excel
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    var excel = new ExcelPackage(new FileInfo(fileName));
                    var ws = excel.Workbook.Worksheets.First();
                    var hasHeader = true;
                    foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                        data.Columns.Add(hasHeader ? firstRowCell.Text
                            : String.Format("Column {0}", firstRowCell.Start.Column));

                    // add DataRows to DataTable
                    int startRow = hasHeader ? 2 : 1;
                    var lastRow = ws.Cells.Where(cell => !string.IsNullOrEmpty(cell.Value?.ToString() ?? string.Empty)).LastOrDefault().End.Row;
                    for (int rowNum = startRow; rowNum <= lastRow; rowNum++)
                    {
                        var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                        DataRow row = data.NewRow();
                        int i = 1;
                        foreach (var cell in wsRow)
                        {
                            if (String.IsNullOrEmpty(cell.Text))
                            {
                                throw new Exception("Dòng " + rowNum + " cột " + i + ": Dữ liệu không được để trống");
                            }
                            row[cell.Start.Column - 1] = cell.Text;
                            i++;
                        }
                        if (i == ws.Dimension.End.Column)
                        {
                            throw new Exception("Dòng " + rowNum + " cột " + i + ": Dữ liệu không được để trống");
                        }
                        data.Rows.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static void ExportExcel(DataTable data)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            dialog.RestoreDirectory = true;
            dialog.Title = "";
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Bạn đã hủy thành công");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    string sheetName = "sheet1";
                    if (data!=null&& data.Rows.Count > 0)
                    {
                        package.Workbook.Worksheets.Add(sheetName);
                        ExcelWorksheet ws = package.Workbook.Worksheets[sheetName];
                        ws.Cells["A1"].LoadFromDataTable(data, true);
                        ws.Cells.AutoFitColumns();
                    }
                    if (package.Workbook.Worksheets.Count <= 0)
                    {
                        package.Workbook.Worksheets.Add(sheetName);
                        ExcelWorksheet ws = package.Workbook.Worksheets[1];
                        ws.Cells[1, 1].Value = "Không có dữ liệu";
                        ws.Cells[1, 1, 1, 5].Merge = true; //Merge columns start and end range
                        ws.Cells[1, 1, 1, 5].Style.Font.Bold = true; //Font should be bold
                        ws.Cells[1, 1, 1, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Aligmnet is center
                        ws.Cells[1, 1, 1, 5].Style.Font.Size = 16;
                        ws.Cells.AutoFitColumns();
                    }
                    //Lưu file lại
                    Byte[] bin = package.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal static object ConvertToList<T>(IEnumerable<ModelTypeWork> selectTypeWork)
        {
            throw new NotImplementedException();
        }

        public static void ExportDefaultExcel(DataTable data)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            dialog.RestoreDirectory = true;
            dialog.Title = "";
            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Bạn đã hủy thành công");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    string sheetName = "sheet1";
                    package.Workbook.Worksheets.Add(sheetName);
                    ExcelWorksheet ws = package.Workbook.Worksheets[sheetName];
                    ws.Cells["A1"].LoadFromDataTable(data, true);
                    ws.Cells.AutoFitColumns();
                    //Lưu file lại
                    Byte[] bin = package.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName.ToLower())
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }
        public static string RandomID(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
    }
}
