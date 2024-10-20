using StudentCRUDDemo1.Views;

namespace StudentCRUDDemo1
{
    public partial class Form1 : Form
    {
        private StudentView studentView;
        public Form1()
        {
            InitializeComponent();
            studentView = new StudentView();
            this.Controls.Add(studentView);
        }
    }
}
