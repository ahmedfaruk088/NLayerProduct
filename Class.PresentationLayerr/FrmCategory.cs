using Class.BusinessLayer.Abstract;
using Class.BusinessLayer.Concrete;
using Class.DataAccessLayer.EntityFramework;
using Class.EntitLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class.PresentationLayerr
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDal());
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori Başarıyla Silindi.");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            dataGridView1.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Başarıyla Eklendi.");
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryID.Text);
            var category = _categoryService.TGetById(id);
            dataGridView1.DataSource = category;
            MessageBox.Show("Kategori Başarıyla Getirildi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedId = int.Parse(txtCategoryID.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);

        }
    }
}
