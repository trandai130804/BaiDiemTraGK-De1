using BaiKiemTraGk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTraGk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var context = new Model1();
                var listStudents = context.SinhViens
                    .Select(s => new
                    {
                        s.MaSV,
                        s.HoTenSV,
                        Lop = s.Lop.TenLop,
                        s.NgaySinh
                    }).ToList();

                dataGridView2.DataSource = listStudents;
                var listFaculties = context.Lops.ToList();
                FillLopCombobox(listFaculties);

                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillLopCombobox(List<Lop> listFaculties)
        {
            cbblop.DataSource = listFaculties;
            cbblop.DisplayMember = "TenLop";
            cbblop.ValueMember = "MaLop";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (var context = new Model1())
                    {
                        var student = new SinhVien
                        {
                            MaSV = txtmssv.Text,
                            HoTenSV = txthoten.Text,
                            NgaySinh = dateTimePicker1.Value,
                            MaLop = (string)cbblop.SelectedValue
                        };

                        context.SinhViens.Add(student);
                        context.SaveChanges();

                        MessageBox.Show("Thêm sinh viên thành công!");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            ResetControls();
        }

        private void LoadData()
        {
            using (var context = new Model1())
            {
                var listStudents = context.SinhViens
                    .Select(s => new
                    {
                        s.MaSV,
                        s.HoTenSV,
                        Lop = s.Lop.TenLop,
                        s.NgaySinh,
                    }).ToList();

                dataGridView2.DataSource = listStudents;
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow != null)
                {
                    string studentID = dataGridView2.CurrentRow.Cells["MaSV"].Value.ToString();

                    using (var context = new Model1())
                    {
                        var student = context.SinhViens.FirstOrDefault(s => s.MaSV == studentID);

                        if (student != null)
                        {
                            context.SinhViens.Remove(student);
                            context.SaveChanges();

                            MessageBox.Show("Xóa sinh viên thành công!");
                            LoadData();
                            ResetControls();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để xóa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow != null)
                {
                    string studentID = dataGridView2.CurrentRow.Cells["MaSV"].Value.ToString();

                    using (var context = new Model1())
                    {
                        var student = context.SinhViens.FirstOrDefault(s => s.MaSV == studentID);

                        if (student != null)
                        {
                            student.HoTenSV = txthoten.Text;
                            student.NgaySinh = dateTimePicker1.Value;
                            student.MaLop = (string)cbblop.SelectedValue;

                            context.SaveChanges();

                            MessageBox.Show("Cập nhật sinh viên thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để sửa.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var query = context.SinhViens.AsQueryable();

                    // Lọc theo Mã sinh viên (MaSV)
                    if (!string.IsNullOrWhiteSpace(txtmssv.Text))
                    {
                        string studentID = txtmssv.Text.Trim();
                        query = query.Where(s => s.MaSV.Contains(studentID));
                    }

                    // Lọc theo Họ tên sinh viên (HoTenSV)
                    if (!string.IsNullOrWhiteSpace(txthoten.Text))
                    {
                        string hoTen = txthoten.Text.Trim();
                        query = query.Where(s => s.HoTenSV.Contains(hoTen));
                    }

                    // Lọc theo Lớp (MaLop)
                    if (cbblop.SelectedValue != null && cbblop.SelectedValue.ToString() != "-1")
                    {
                        string facultyID = cbblop.SelectedValue.ToString();
                        query = query.Where(s => s.MaLop == facultyID);
                    }

                    // Lấy kết quả và hiển thị
                    var result = query.Select(s => new
                    {
                        s.MaSV,
                        s.HoTenSV,
                        TenLop = s.Lop.TenLop // Hiển thị tên lớp từ quan hệ
                    }).ToList();

                    dataGridView2.DataSource = result;

                    if (result.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Kiểm tra trạng thái (Thêm, Sửa hoặc Xóa) và xử lý tương ứng
                    if (txtmssv.Enabled) // Nếu thêm mới
                    {
                        var newStudent = new SinhVien
                        {
                            MaSV = txtmssv.Text,
                            HoTenSV = txthoten.Text,
                            NgaySinh = dateTimePicker1.Value,
                            MaLop = cbblop.SelectedValue.ToString()
                        };

                        context.SinhViens.Add(newStudent);
                    }
                    else if (txthoten.Enabled) // Nếu sửa
                    {
                        var student = context.SinhViens.FirstOrDefault(s => s.MaSV == txtmssv.Text);
                        if (student != null)
                        {
                            student.HoTenSV = txthoten.Text;
                            student.NgaySinh = dateTimePicker1.Value;
                            student.MaLop = cbblop.SelectedValue.ToString();
                        }
                    }
                    else // Nếu xóa
                    {
                        var student = context.SinhViens.FirstOrDefault(s => s.MaSV == txtmssv.Text);
                        if (student != null)
                        {
                            context.SinhViens.Remove(student);
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Thao tác thành công!");

                    // Tải lại dữ liệu và reset giao diện
                    LoadData();
                    ResetControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void ResetControls()
        {
            // Tắt các nút Lưu và Không Lưu
            btnluu.Visible = true;
            btnkluu.Visible = true;
        }

        private void btnkluu_Click(object sender, EventArgs e)
        {
            // Hủy bỏ thao tác và reset giao diện
            ResetControls();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    txtmssv.Text = row.Cells["MaSV"].Value?.ToString();
                    txthoten.Text = row.Cells["HoTenSV"].Value?.ToString();
                    dateTimePicker1.Value = row.Cells["NgaySinh"].Value != null
                        ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                        : DateTime.Now;
                    cbblop.Text = row.Cells["Lop"].Value?.ToString();
                    ResetControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}