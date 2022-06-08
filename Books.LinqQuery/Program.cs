
using Books.DAL.Context;

namespace Books.LinqQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Select
            //using (var db = new AppDbContext())
            //{
            //    var sonuc = from book in db.Books
            //                select new
            //                {
            //                    book.Id,
            //                    book.Title,
            //                    book.Price

            //                };
            //    foreach (var item in sonuc)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //}
            //using (var db = new AppdbContext())
            //{

            //    //Anonim tipte DataTransfer olusturma
            //    //var genreList = db.Genres
            //    //                .Select(g=> new { 
            //    //                                  TurId=  g.Id,
            //    //                                  TurAdi=  g.Name,
            //    //                                  KayitTarihi=  g.CreateDate
            //    //                            });


            //    //concrete tipte datatransfer olusturma
            //    var genreList = db.Genres.Select(g => new genreListDto
            //    {
            //        TurId = g.Id,
            //        TurAdi= g.Name,
            //        KayitTarihi = g.CreateDate
            //    });

            //    foreach (var item in genreList)
            //    {
            //        Console.WriteLine(item.TurId + " " + item.TurAdi+ " " + item.KayitTarihi);
            //    }
            //}




            #endregion

            #region Where-1

            //LinqToSql
            //using (var db = new AppDbContext())
            //{
            //    var sonuc = from b in db.Books
            //                where b.Price > 10 && b.Price < 50
            //                orderby b.Title
            //                select new
            //                {
            //                    b.Id,
            //                    b.Title,
            //                    b.Price
            //                };
            //    foreach (var item in sonuc)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //}
            // fiyati 7-11 arasi olan kitaplari listelemek

            //using (var db = new AppdbContext())
            //{
            //    var bookList = db.Books
            //        .Where(b => b.Price >= 7 && b.Price <= 11)//Sorgunun Where Sarti
            //        .Select(b=> new { b.Title,b.Price}) // Hangi alanlarin gelmesini istiyorsak burada belirtiyoruz
            //        .ToList(); // Gelen Sonucu bana List'e olarak ver

            //    foreach (var item in bookList)
            //    {
            //        Console.WriteLine(item.Title + ":" + item.Price);
            //    }
            //}

            #endregion
            #region  Where-2
            // Id'si 3-10 arasinda olan yazarlarin Id,firstName,lastName listeyin
            //using (var db = new AppdbContext())
            //{
            //    var bookList = db.Authors
            //        .Where(b => b.Id >= 3 && b.Id<= 10)//Sorgunun Where Sarti
            //        .Select(b => new { b.Id, b.FirstName,b.LastName}) // Hangi alanlarin gelmesini istiyorsak burada belirtiyoruz
            //        .ToList(); // Gelen Sonucu bana List'e olarak ver

            //    foreach (var item in bookList)
            //    {
            //        Console.WriteLine(item.Id + ":" + item.FirstName+" " + item.LastName);
            //    }
            //}
            #endregion


            #region Orderby-1
            //Id'si 1-10 arasinda olan yazarlari a-z siralayin
            //using (var db = new AppdbContext())
            //{
            //    var bookList = db.Authors
            //        .Where(b => b.Id >= 1 && b.Id <= 10)//Sorgunun Where Sarti
            //        .OrderBy(b=>b.FirstName)
            //        .Select(b => new { b.Id, b.FirstName, b.LastName }) // Hangi alanlarin gelmesini istiyorsak burada belirtiyoruz
            //        .ToList(); // Gelen Sonucu bana List'e olarak ver

            //    foreach (var item in bookList)
            //    {
            //        Console.WriteLine(item.Id + ":" + item.FirstName + " " + item.LastName);
            //    }
            //}
            #endregion
            #region Orderby-2
            // fiyati 10 dan buyuk olan kitaplari fiyati buyukten kucuge dogru siralayin
            //using (var db = new AppdbContext())
            //{
            //    var bookList = db.Books
            //        .Where(b => b.Price>=10)//Sorgunun Where Sarti
            //        .OrderByDescending(b => b.Price)
            //        .Select(b => new { b.Id, b.Title, b.Price}) // Hangi alanlarin gelmesini istiyorsak burada belirtiyoruz
            //        .ToList(); // Gelen Sonucu bana List'e olarak ver

            //    foreach (var item in bookList)
            //    {
            //        Console.WriteLine(item.Id + ":" + item.Title + " " + item.Price);
            //    }
            //}

            #endregion

            #region First-1
            // Kitap Tablosundaki ilk kaydi getirelim
            //using (var db = new AppdbContext())
            //{
            //    var book = db.Books.First();
            //    var book2 = db.Books.FirstOrDefault();//Bu metod kaydi bulamaz ise hata vermez        
            //    Console.WriteLine(book.Id + ":" + book.Title);
            //    Console.WriteLine(book2.Id + ":" + book2.Title);

            //}
            #endregion
            #region First-2
            // Kitap Tablosundaki ilk kaydi getirelim
            //using (var db = new AppDbContext())
            //{
            //    try
            //    {
            //        //var book = db.Books.First(b => b.Id > 50);
            //        var book2 = db.Books.FirstOrDefault(b => b.Id > 50);//Bu metod kaydi bulamaz ise hata vermez        
            //        Console.WriteLine(book2.Id + ":" + book2.Title);

            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }


            //}
            #endregion
            #region Take
            ////fiyati en yüksek ilk 5 kitap
            ////sql : selecet top 5 * from Books order by price desc
            //using (var db = new AppDbContext())
            //{
            //    //linqMetod
            //    var Kitaplar = db.Books
            //                     .OrderByDescending(p => p.Price)
            //                     .Take(5)
            //                     .Select(x => new
            //                     {
            //                         x.Id,
            //                         x.Title,
            //                         x.Price
            //                     });

            //    //LinqtoSql
            //    var Kitaplar2 = (from b in db.Books
            //                     orderby b.Price descending
            //                     select new
            //                     {
            //                         b.Id,
            //                         b.Title,
            //                         b.Price
            //                     }).Take(5);
            //    foreach (var item in Kitaplar)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //    Console.WriteLine("--------------------Linq To Sql-------------------------");
            //    foreach (var item in Kitaplar2)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //}
            #endregion
            #region Take & Skip
            //Kategorisi "History" olan ve fiyati en yüksek 6. kitabi getirin
            //using (var db = new AppDbContext())
            //{
            //LinqToMetod
            //    var result = db.Books
            //                   .Where(p => p.GenreId == "history")
            //                   .OrderByDescending(p => p.Price)
            //                   .Skip(5)
            //                   .Take(1)
            //                   .Select(p => new
            //                   {
            //                       p.Id,
            //                       p.Title,
            //                       p.Price
            //                   });
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //    Console.WriteLine("--------------------------LinqToSql------------------------------------");
            //    //LinqToSql
            //    var result2 = (from b in db.Books
            //                   where b.GenreId == "history"
            //                   orderby b.Price descending
            //                   select new
            //                   {
            //                       b.Id,
            //                       b.Title,
            //                       b.Price
            //                   }).Skip(5).Take(1).ToList();
            //    foreach (var item in result2)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}{item.Price}");
            //    }
            //}
            #endregion
            #region Contains
            //içerisinde "A" harfi gecen kitaplarin listesi
            //select * from books where title like '%a%'

            //using (var db = new AppDbContext())
            //{
            ////LinqToSql
            //var sonuc = (from b in db.Books
            //            where b.Title.Contains("a")
            //            select new
            //            {
            //                b.Id,
            //                b.Title,

            //            }).ToList();
            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine($"{item.Id}{item.Title}");
            //}
            //Console.WriteLine("---------------------LinqToMetod-------------------");
            ////LinqToMetod
            //var sonuc2 = db.Books.Where(p => p.Title.Contains("a")).ToList();
            //foreach (var item in sonuc2)
            //{
            //    Console.WriteLine($"{item.Id}{item.Title}");
            //}
            //}
            #endregion
            #region StartWith
            //b harfi ile baslayan kitapların listesi
            // select * from books where title like 'b%'
            //using (var db = new AppDbContext())
            //{
            //    var sonuc = from b in db.Books
            //                where b.Title.StartsWith("b")
            //                select new 
            //                {
            //                    b.Id,
            //                    b.Title
            //                };
            //    Console.WriteLine("--------------------------LinqToMetod------------------------------");
            //    //LinqToMetod
            //    var sonuc2 = db.Books.Where(p => p.Title.StartsWith("b")).Select(p => new { p.Id, p.Title }).ToList();
            //    foreach (var item in sonuc.ToList())
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}");
            //    }
            //Console.WriteLine("-------------------------------LinqToMetod----------------------------------");
            //    foreach (var item in sonuc2)
            //    {
            //        Console.WriteLine($"{item.Id}{item.Title}");
            //    }
            //}
            #endregion
            #region Any-1
            //Books tablosunda turu "history" olan kitap varmı _?
            //turu h ile başlayan kitap varmı _?
            //using (var db = new AppDbContext())
            //{
            //    //LinqToMetod
            //    var sonuc = db.Books.Any(p => p.GenreId == "history");

            //    var sonuc2 = db.Books.Any(p => p.GenreId.StartsWith("h"));

            //    Console.WriteLine($"Sonuc:{sonuc}\n Sonuc2{sonuc2}");
            //}
            #endregion
            //Aggregate Functions
            #region Count & Sum
            //toplam kitap sayımız nedir, kitaplarin fiyat toplamı nedir
            //Sql:select count(*) from books
            //using (var db= new AppDbContext())
            //{
            //    var adet = db.Books.Count();
            //    var FiyatToplami = db.Books.Sum(p => p.Price);
            //    Console.WriteLine($"Toplam Kitap Sayisi:{adet}\nFiyat Toplamı:{FiyatToplami}");
            //}
            #endregion
            #region Min & Max
            //En Pahali Kitap ve En Ucuz Kitap Hangisidir
            //using (var db = new AppDbContext())
            //{
            //    var EnPahali = db.Books.Max(p => p.Price);
            //    var EnUcuz = db.Books.Min(p => p.Price);
            //    Console.WriteLine($"En Pahali Kitap Fiyati:{EnPahali}\nEn Ucuz Kitap Fiyati:{EnUcuz}");
            //}
            #endregion
            #region Group by
            //Hangi turden kac adat kitap vardir.
            //using (var db = new AppDbContext())
            //{
            //    var KitapListesi = db.Books
            //                        .GroupBy(p => p.Genre.Name)
            //                        .Select(b => new
            //                        {
            //                            KitapTuru=b.Key,
            //                            Adet=b.Count()
            //                        }).ToList();

            //    var KitapListesi2 = from b in db.Books
            //                        group b by b.Genre.Name into k
            //                        select new
            //                        {
            //                            Tur = k.Key,
            //                            Adet = k.Count()

            //                        };
            //    int ToplamAdet = 0;
            //    foreach (var item in KitapListesi)
            //    {
            //        Console.WriteLine($"Tur:{item.KitapTuru}Adet:{item.Adet}");
            //        ToplamAdet += item.Adet;
            //    }
            //    Console.WriteLine($"Toplam:"+ToplamAdet);
            //    Console.WriteLine($"------------------------------------LinqToSql-----------------------------------------");
            //    foreach (var item in KitapListesi2.ToList())
            //    {
            //        Console.WriteLine($"Tur:{item.Tur}Adet:{item.Adet}");
            //    }

            //}
            #endregion
            #region Groupby 2
            ////Hangi yazarin 2 den fazla kitabi var
            //using (var db = new AppDbContext())
            //{
            //    var result = db.BookAuthors
            //                 .GroupBy(p => p.Author.FirstName)
            //                 .Select(p => new
            //                 {
            //                     Yazar = p.Key,
            //                     Adet = p.Count()
            //                 })
            //                 .Where(p => p.Adet >= 2)
            //                 .OrderByDescending(p => p.Adet)
            //                 .ToList();
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"Yazar:{item.Yazar} Adet:{item.Adet}");
            //    }
            //}
            #endregion
            #region Groupby with sum
            //Kategorilerine gore toplam kitap tutarları
            //using (var db = new AppDbContext())
            //{
            //    var result = db.Books
            //                  .GroupBy(b => b.Genre.Name)
            //                  .Select(b => new
            //                  {
            //                      Tur=b.Key,
            //                      FiyatToplami=b.Sum(z=>z.Price)
            //                  }).ToList();
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"Tur:{item.Tur} ToplamFiyat:{item.FiyatToplami}");
            //    }
            //}
            #endregion
        }
    }
}



