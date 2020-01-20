using Crm.BL.EF;
using Crm.BL.Model;
using Crm.UI.Enums;
using Crm.UI.Factories;
using System.Data.Entity;
using System.Windows.Forms;

namespace Crm.UI
{
    public partial class Catalog<T> : Form
    {
        DbSet<T> _set;
        CrmContext _db;
        FormFactory _formFactory;
        FormTypes _type;

        public Catalog(DbSet<T> set, FormTypes type)
        {
            _db = new CrmContext();
            _set = _db.Set<T>();
            _formFactory = new FormFactory();
            _type = type;

            InitializeComponent();

            set.Load();

            dataGridView1.DataSource = set.Local.ToBindingList();
        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;

            var entity = _set.Find(id);

            if (entity != null)
            {
                var form = _formFactory.CreateForm(_type, entity);

                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    _db.Entry(entity).State = EntityState.Modified;
                    _db.SaveChanges();

                    dataGridView1.Update();
                }
            }
        }
    }
}
