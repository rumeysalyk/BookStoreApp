using System.Collections.Generic;
using System.Linq;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public class BookRepository
    {
        private static List<Book> books = null;

        static BookRepository (){
            books = new List<Book>(){
                new Book(){
                     Id=1, 
                     Name = "Devlet", 
                     ShortDescription="\"Kötülüklerin ilki ve en büyüğü,haksızlıkların cezasız kalmasıdır\"",
                     Description ="\"Demokrasinin esas prensibi, halkın egemenliğidir. Ama milletin kendini yönetecekleri iyi seçebilmesi için, yetişkin ve iyi eğitim görmüş olması şarttır. Eğer bu sağlanamazsa demokrasi, otokrasiye geçebilir. Halk övülmeyi sever. Onun için, güzel sözlü demagoglar, kötü de olsalar, başa geçebilirler. Oy toplamasını bilen herkesin, devleti idare edebileceği zannedilir. Demokrasi, bir eğitim işidir. Eğitimsiz kitlelerle demokrasiye geçilirse oligarşi olur. Devam edilirse demagoglar türer. Demagoglardan da diktatörler çıkar.\"", 
                     ImageUrl="Devlet.jpg",
                     CategoryId = 1,
                     },
                new Book()
                {
                     Id=2, 
                     Name = "Yaşam Felsefesi", 
                     ShortDescription="\"Güzellik,nesnenin amaca uygun gelmesinin biçimidir\"",
                     Description ="\"Bizler sırlarla dolu bir evrende bir rüyanın rüyasını görmekteyiz. Gerçekte bildiğimiz hiçbir şey yoktur. Bildiğimizi sandığımız şey sadece olaylardır. O olaylar ki, bilmediğimiz bir nesneyle asla bilemeyeceğimiz bir öznenin birbirlerine olan ilişkisinden doğmuştur.\"", 
                     ImageUrl="YasamFelsefesi.jpg",
                     CategoryId = 1

                },
                
                new Book()
                { 
                    Id=3, 
                    Name = "Acı Kahve", 
                    ShortDescription="\"Çünkü, bir köpeği iz peşine takmak zordur, madam. Ancak burnu bir kez kokuyu aldı mı, onu vazgeçirmek imkansızdır.\"" ,
                    Description ="\"Ünlü bir fizikçi olan Sir Claude Avory savunma sanayi alanında çok önemli bir formül üretir. Ancak aile fertlerinin bu formülü çalacağından şüphe etmektedir. Duruma açıklık getirmesi için ünlü dedektif Hercule Poirot'yu malikânesine davet eder. Bu arada Sir Avory tüm aile fertlerini de çağırmıştır. Yemek sonrası kütüphanede bir yandan kahvesini yudumlarken bir yandan da onlarla sohbet edecektir. Çünkü formülün akrabaları tarafından çalındığını anlamıştır.\"",
                    ImageUrl="AciKahve.jpg",
                    CategoryId =2
                },
                
                new Book()
                { 
                    Id=4, 
                    Name = "İrade Terbiyesi",
                    ShortDescription="\"Çalışmak özgürlüktür.\"" ,
                    Description ="\"Cemil Meric'in \"Disiplin içinde çalışmayı bu kitaptan öğrendim.\" diye tarif ettiği \"İrade Terbiyesi\" İlk yayımlandığı tarihten itibaren pek çok dile çevrilmiş ve tembellik, İsteksizlik gibi huylardan kurtulmak isteyenlerin başucu kitabı olmuştur.Kitapta bilhassa gençlere ve zihnini kullanarak çalışanlara hitap eden Fransız profesör kendi hayatından aktardığı Örnekleri ve başka düşünürlerin tespitlerini de kullanarak İnsanın İrade zayıflığıyla nasıl mücadele etmesi gerektiğini anlatıyor. Prof.Dr. Ali Fuat Başgil Gençlerle Başbaşa kitabında şöyle demektedir\"Mösyö Girard bize bir kitap tavsiye etti ve mutlaka okumamızı söyledi. Bu, Aix-Marseille Üniversitesi rektörü Jules Payot'un \"irade Terbiyesi\" adlı kitabı İdi. Ertesi gün şehre İnerek kitabı aldım, ihtiyar bir meşenin dibine oturarak İrade Terbiyesi'ni okumaya koyuldum. Okudukça İçimde tahassür ve nedametle karışık müphem bir acı duymaya başladım. Kendi kendime, ah bu kitap on sekiz yirmi yaşlarımdayken elime geçmeliydi diyor ve geciktiğim için üzülüyordum.\"",
                    ImageUrl="IradeTerbiyesi.jpg",
                    CategoryId = 3
                },
                new Book()
                { 
                    Id=5, 
                    Name = "Aklın Şüphesi",
                    ShortDescription="\"Aklın şüphesi suçun gerçeğidir\"",
                    Description ="\"Sıradan olmayan bir şeyin, bir engel olmaktan öte, bir yol gösterici olduğunu size çoktan söylemiştim. Bu tür bir sorunu çözerken en önemli şey olayların ardında yatanlar hakkında mantık yürütebilmektir. Bu çok faydalı ve kolay bir yoldur ama insanlar bu yola pek başvurmazlar. Hayatın gündelik olaylarında ise ilerisi hakkında mantık yürütmek daha faydalı olduğundan diğer yol unutulur. Senaaa yoluyla mantık yürüten elli kişi varsa çözümlemelere vararak mantık yürüten bir kişi vardır.\"", 
                    ImageUrl="AklinSuphesi.jpg",
                    CategoryId =2
                },

            };
        }

        public static List<Book> Books{
            get{
                return books;
            }
        }

        public static void AddBook(Book item){
            books.Add(item);
        }

        public static Book GetById(int id)
        {
            return books.FirstOrDefault(i => i.Id == id);
        }

    }
}