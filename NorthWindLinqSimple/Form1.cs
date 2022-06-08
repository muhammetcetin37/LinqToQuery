using NorthWindLinqSimple.Models;
namespace NorthWindLinqSimple
{
    public partial class Form1 : Form
    {
        NorthwindContext db =new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kategorilerin Topla urun sayilari nedir?

            var sonuc = (from c in db.Categories
                         join urun in db.Products
                         on c.CategoryId equals urun.CategoryId
                         group c by c.CategoryName into k
                         select new
                         {
                             Categori = k.Key,
                             Adet = k.Count()
                         }).ToList();
            dataGridView1.DataSource = sonuc;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //order tablosundaki sorgu ancak customerId yerine campanyName gelsin 
            //emloyeeId yerine firstName ve lastname gelsin
            //shipvia yerine shipper tablosunda companyname gelsin
            var sonuc = from o in db.Orders
                        join c in db.Customers on o.CustomerId equals c.CustomerId
                        join emp in db.Employees on o.EmployeeId equals emp.EmployeeId
                        join s in db.Shippers on o.ShipVia equals s.ShipperId
                        select new
                        {
                            OrderId = o.OrderId,
                            SiparisiVeren = c.CompanyName,
                            SiparisiAlan = emp.FirstName + " " + emp.LastName,
                            SiparisTarihi = o.OrderDate,
                            Kargo = s.CompanyName
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calisanlarin aldıgı siparis sayilari nedir
            //Linq to sql sorgusu
            var sonuc = from emp in db.Employees
                        join o in db.Orders on emp.EmployeeId equals o.EmployeeId
                        group emp by (emp.FirstName + " " + emp.LastName) into k
                        select new
                        {
                            Calisan = k.Key,
                            Adet = k.Count()
                        };
            
            //linqToMethod
            //var sonuc2 = db.Employees.Join(db.Orders
            //                               , emp => emp.EmployeeId
            //                               , order => order.EmployeeId, (emp,order) => new
            //                               {
            //                                   Calisan =emp.FirstName +" "+emp.LastName,
            //                                   AldigiSiparis=order.OrderId
            //                               }).GroupBy(x=>x.Calisan).ToList();
            dataGridView1.DataSource= sonuc.ToList();
                       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //hangi üründen kaç adet satılmış
            // müşterilerin verdigi sipariş sayısı nedir
            //yıllara göre siparis dagılımı nedir
            //kargocuların tasıdıgı siparis sayıları nelerdir
            //hangi tedarikciden kaç adet ürün alıyoruz
            //categorilere göre siparis dagılımı nedir
            //müşterilerin ciro dagılımı nedir
            
        }
    }
}