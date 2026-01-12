using Lab07_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class UpdateFoodForm : Form
    {
        private RestaurantContext _dbContext;
        public int _foodId;
        public UpdateFoodForm(int? foodId = null)
        {
            InitializeComponent();
            _dbContext = new RestaurantContext();
            _foodId = foodId ?? 0;
        }

        private void LoadCategoriesToCombobox()
        {
            // Lấy tất cả danh mục thức ăn, sắp tăng theo tên
            var categories = _dbContext.Categories
                .OrderBy(x => x.Name).ToList();

            // Nạp danh mục vào combobox, hiển thị tên cho người
            // dùng xem nhưng khi được chọn thì lấy giá trị là ID
            cboFoodCategory.DisplayMember = "Name";
            cboFoodCategory.ValueMember = "Id";
            cboFoodCategory.DataSource = categories;
        }

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
            ShowFoodInfo();
        }

        private Food GetFoodById(int foodId)
        {
            return foodId > 0 ? _dbContext.Foods.Find(foodId) : null;
        }

        private void ShowFoodInfo()
        {
            var food = GetFoodById(_foodId);
            if (food == null) return;
            txtFoodID.Text = food.Id.ToString();
            txtFoodName.Text = food.Name;
            cboFoodCategory.SelectedValue = food.FoodCategoryId;
            txtFoodUnit.Text = food.Unit;
            numFoodPrice.Value = food.Price;
            rtxtFoodNotes.Text = food.Notes;

        }

        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn không được để trống", "Thông báo");
                return false;
            }
            if (numFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá món ăn phải lớn hơn 0", "Thông báo");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo");
                return false;
            }
            if (cboFoodCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn nhóm món ăn", "Thông báo");
                return false;
            }
            return true;
        }

        private Food GetUpdatedFood()
        {
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryId = (int)cboFoodCategory.SelectedValue,
                Unit = txtFoodUnit.Text.Trim(),
                Price = (int)numFoodPrice.Value,
                Notes = rtxtFoodNotes.Text.Trim()
            };
            if (_foodId > 0)
            {
                food.Id = _foodId;
            }
            return food;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newfood = GetUpdatedFood();
                var oldfood = GetFoodById(_foodId);

                if (oldfood == null)
                {
                    // Thêm món ăn mới
                    _dbContext.Foods.Add(newfood);
                }
                else
                {
                    // Cập nhật món ăn
                    oldfood.Name = newfood.Name;
                    oldfood.FoodCategoryId = newfood.FoodCategoryId;
                    oldfood.Unit = newfood.Unit;
                    oldfood.Price = newfood.Price;
                    oldfood.Notes = newfood.Notes;
                }

                _dbContext.SaveChanges();
                this.DialogResult = DialogResult.OK;

            }
        }



    }
}
