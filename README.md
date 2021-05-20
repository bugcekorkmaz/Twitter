# Twitter

17.05.2021
Twitter.Core katmanını ve Twitter.Model Entities katmanında class'larımı oluşturdum.


18.05.2021
Context klasörü oluşturup TwitterContext sınıfı oluşturup, constructor ve Dbset'lerimi oluşturdum. Maps klasörü oluşturup içine Entities'deki classlarımın Mapleme işlemini yaptım. Ayrıca TwitterContext'de tetiklemesini yaptım. TwitterContext'de SaveChanges() methodunu yazdıktan sonra yeni bir class library olarak Twitter.Service katmanını oluşturdum. BaseService classını oluşturdum. Sonra Twitter Mvc katmanında üç tane bileşeni nuget'ten kurdum. ConnectionStringi appsettings.json dosyasının içerisine koydum.
Startup'ta ConfigureServices kısmında DbContext ve UseSqlServer methodunu yazdım.
