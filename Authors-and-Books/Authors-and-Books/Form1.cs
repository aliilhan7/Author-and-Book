using Authors_and_Books.Entities;
using System.Windows.Forms;

namespace Authors_and_Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AuthorBookDal _authorBookDal = new AuthorBookDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadAuthorsBooks();
            BindAuthorsToDataGridView(dgwList);
            BindBooksToDataGridView(dgwList);
        }
        public void BindAuthorsToDataGridView(DataGridView dataGridView)
        {
            List<Author> Authors = _authorBookDal.ListAll();
            dataGridView.DataSource = Authors;
            dataGridView.Columns["AuthorName"].HeaderText = "Author Name";
        }
        public void BindBooksToDataGridView(DataGridView dataGridView)
        {
            List<Book> Books = _authorBookDal.ListAll2();
            dataGridView.DataSource = Books;
            dataGridView.Columns["BookName"].HeaderText = "Book Name";
        }


        private void LoadAuthorsBooks()
        {
            dgwList.DataSource = _authorBookDal.ListAll();
            dgwList.DataSource = _authorBookDal.ListAll2();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            LoadAuthorsBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _authorBookDal.Add(new Author
            {
                AuthorName = tbxAuthorName.Text,
            });
            _authorBookDal.Add(new Book
            {
                BookName = tbxBookName.Text,
                Content = tbxContent.Text
            });
            LoadAuthorsBooks();

            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _authorBookDal.Update(new Author
            {
                Id = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value),
                AuthorName = tbxAuthorName.Text
            });
            _authorBookDal.Update(new Book
            {
                Id = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value),
                BookName = tbxBookName.Text,
                Content = tbxContent.Text
            });
            LoadAuthorsBooks();

            MessageBox.Show("Updated!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _authorBookDal.Delete(new Author
            {
                Id = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value),
            });
            _authorBookDal.Delete(new Book
            {
                Id = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value),
            });
            LoadAuthorsBooks();
            MessageBox.Show("Deleted!");
        }
        private void dgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAuthorName.Text = dgwList.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwList.CurrentRow.Cells[2].Value.ToString();
            tbxContent.Text = dgwList.CurrentRow.Cells[3].Value.ToString();
        }
    }
}