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
using static Lab07_Entity_Framework.Models.Category;

namespace Lab07_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private List<Category> GetCategories()
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            // Lấy danh sách tất cả nhóm thức ăn, sắp xếp theo tên
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void ShowCategories()
        {
            // Xóa tất cả các nút hiện có trên cây
            tvwCategory.Nodes.Clear();
            // Tạo danh sách loại nhóm thức ăn, đồ uống
            // Tên của các loại này được hiển thị trên các nút mức 2
            var catMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            // Lấy danh sách nhóm đồ ăn, thức uống
            var categories = GetCategories();

            // Duyệt qua các loại nhóm thức ăn
            foreach (var catType in catMap)
            {
                // Tạo các nút tương ứng với loại nhóm thức ăn
                var childNode = rootNode.Nodes.Add(catType.Key.ToString(), catType.Value);
                childNode.Tag = catType.Key;

                // Duyệt qua các nhóm thức ăn
                foreach (var category in categories)
                {
                    // Nếu nhóm đang xét không cùng loại thì bỏ qua
                    if (category.Type != catType.Key) continue;

                    // Ngược lại, tạo các nút tương ứng trên cây
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }

            // Mở rộng các nhánh của cây để thấy hết tất cả các nhóm thức ăn
            tvwCategory.ExpandAll();

            // Đánh dấu nút gốc đang được chọn
            tvwCategory.SelectedNode = rootNode;
        }

        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            // Khởi tạo đối tượng context
            var dbContext = new RestaurantContext();

            // Tạo truy vấn lấy danh sách món ăn
            var foods = dbContext.Foods.AsQueryable();

            // Nếu mã nhóm món ăn khác null và hợp lệ
            if (categoryId != null && categoryId > 0)
            {
                // Thì tìm theo mã số nhóm thức ăn
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }

            // Sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chứa đầy đủ thông tin về món ăn.
            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            // Tìm các món ăn theo loại nhóm thức ăn (Category Type).
            // Sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chứa đầy đủ thông tin về món ăn.
            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private void ShowFoodsForNode(TreeNode node)
        {
            // Xóa danh sách thực đơn hiện tại khỏi listview
            lvFood.Items.Clear();
            // Nếu node = null, không cần xử lý gì thêm
            if (node == null) return;
            // Tạo danh sách để chứa danh sách các món ăn tìm được
            List<FoodModel> foods = null;
            // Nếu nút được chọn trên TreeView tương ứng với
            // loại nhóm thức ăn (Category Type) (mức thứ 2 trên cây)
            if (node.Level == 1)
            {
                // Thì lấy danh sách món ăn theo loại nhóm
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                // Ngược lại, lấy danh sách món ăn theo thể loại
                // Nếu nút được chọn là 'Tất cả' thì lấy hết
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }
            // Gọi hàm để hiển thị các món ăn lên ListView
            ShowFoodsOnListView(foods);
        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            // Duyệt qua từng phần tử của danh sách food
            foreach (var foodItem in foods)
            {
                // Tạo item tương ứng trên ListView
                var item = lvFood.Items.Add(foodItem.Id.ToString());

                // Và hiển thị các thông tin của món ăn
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void SetupListViewColumns()
        {
            lvFood.View = View.Details;
            lvFood.FullRowSelect = true;
            lvFood.GridLines = true;

            lvFood.Columns.Clear();
            lvFood.Columns.Add("Mã số", 60);
            lvFood.Columns.Add("Tên món", 150);
            lvFood.Columns.Add("Đơn vị", 80);
            lvFood.Columns.Add("Giá", 100);
            lvFood.Columns.Add("Nhóm", 120);
            lvFood.Columns.Add("Ghi chú", 200);
        }


        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ShowCategories();
            }    
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;

            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count == 0) return;

            var selectedFoodId = int.Parse(lvFood.SelectedItems[0].Text);

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?",
                                        "Xác nhận xóa",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var dbContext = new RestaurantContext();
                    var selectedFood = dbContext.Foods.Find(selectedFoodId);

                    if (selectedFood != null)
                    {
                        // XÓA CÁC CHI TIẾT HÓA ĐƠN LIÊN QUAN TRƯỚC
                        var billDetails = dbContext.BillDetails.Where(x => x.FoodID == selectedFoodId).ToList();
                        dbContext.BillDetails.RemoveRange(billDetails);

                        // SAU ĐÓ XÓA MÓN ĂN
                        dbContext.Foods.Remove(selectedFood);
                        dbContext.SaveChanges();

                        // CẬP NHẬT GIAO DIỆN
                        lvFood.Items.Remove(lvFood.SelectedItems[0]);
                        MessageBox.Show("Xóa món ăn thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể xóa món ăn này. Lỗi: {ex.InnerException?.Message}",
                                  "Lỗi",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateFoodForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }

        private void lvFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count == 0) return;
            var foodId = int.Parse(lvFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }



    }
}