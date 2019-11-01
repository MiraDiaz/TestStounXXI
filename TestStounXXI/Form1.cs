using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace TestStounXXI
{
    public partial class Form1 : Form
    {
        ExchangeRatersModel db;
        public Form1()
        {
           
            InitializeComponent();

            db = new ExchangeRatersModel();
            

            db.DirectoryCurrence.Load();
            db.ExchangeRates.Load();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            dataGridViewDC.DataSource = db.DirectoryCurrence.Local.ToBindingList();
            dataGridViewER.DataSource = db.ExchangeRates.Local.ToBindingList();

            XDocument xdoc = XDocument.Load("http://www.cbr.ru/scripts/XML_daily.asp?date_req=21.08.2019");
            

            var items = from xe in xdoc.Element("ValCurs").Elements("Valute")
                            select new DirectoryCurr
                            {
                                CurrencyCode = xe.Attribute("ID").Value,
                                CharCode = xe.Element("CharCode").Value
                            };
                foreach (var item in items)
                {
                    DirectoryCurr directoryCurrence = new DirectoryCurr();
                    directoryCurrence.CurrencyCode = item.CurrencyCode;
                    directoryCurrence.CharCode = item.CharCode;

                    db.DirectoryCurrence.Add(directoryCurrence);
                    db.SaveChanges();
                }

            var itemsER = from xe in xdoc.Elements("ValCurs")
                          from xe1 in xdoc.Element("ValCurs").Elements("Valute")
                          select new ExchangeRat
                          {
                              Data = DateTime.ParseExact(xe.Attribute("Date").Value, "dd.MM.yyyy",null),
                              CharCode = xe1.Element("CharCode").Value,
                              Rate = decimal.Parse(xe1.Element("Value").Value)
                          };
           
           foreach (var item in itemsER)
            {
                ExchangeRat exchangeRate = new ExchangeRat();
                exchangeRate.Data = item.Data;
                exchangeRate.CharCode = item.CharCode;
                exchangeRate.Rate = item.Rate;
                

                db.ExchangeRates.Add(exchangeRate);
                db.SaveChanges();
                
            }
                
        }
    }
}
