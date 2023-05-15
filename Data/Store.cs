namespace loginuser.Data;

public static class Store
{
    public static List<User> Users = new List<User>{
        new User{Id=1,Username="user1",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=2,Username="user2",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=3,Username="user3",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=4,Username="user4",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=5,Username="user5",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=6,Username="user6",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=7,Username="user7",FirstName="Yasemin",LastName="Topsakal"},
        new User{Id=8,Username="user8",FirstName="Yasemin",LastName="Topsakal"},
    };
    public static List<Product> Products = new List<Product>{
        new Product{Id=1,Name="Sıfırdan İleri Düzey Web Geliştirme",Description=" HTML, CSS, JavaScript, Bootstrapt, JQuery konularını derinlemesine öğrenerek profesyonel web sayfaları oluşturun! (80 saat)",Price=80,Image="https://images.pexels.com/photos/14553730/pexels-photo-14553730.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1, Education="Hiçbir programlama bilgisine sahip olmasanız dahi bu kursa rahatlıkla başlayabileceksiniz. Web Geliştirici olmak için tüm konuları öğrenmiş olacaksınız. Bir blog sitesi tasarlayıp bu sitelerden para kazanabileceksiniz. Bootstrap ile modern görünümlü web sayfaları oluşturabileceksiniz. HTML ve CSS kodlamayı öğrenerek efektif web siteleri oluşturabileceksiniz. "},
        new Product{Id=2,Name="Sıfırdan Komple Java Geliştirici Kursu",Description="Android , Web Geliştirme ve daha bir çok alanda kullanılan Java Programlama Dilini öğrenmenin tadını çıkarın. (42 saat)",Price=100,Image="https://images.pexels.com/photos/11035360/pexels-photo-11035360.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",value=1, Education="Nesne Yönelimli Programlamanın tüm konseptlerini iyi bir şekilde öğrenmiş olacaksınız. Multithreading konseptlerini öğrenerek uygulamalarınızı bu doğrultuda yazabileceksiniz.Dosya işlemlerini öğrenerek programlarınızda dosyaları ve diğer dış kaynakları kullanabileceksiniz. En önemlisi, artık CV'nize Javayı ileri seviyede biliyorum yazabileceksiniz. "},
        new Product{Id=3,Name="Sıfırdan İleri Seviye Modern Javascript Dersleri ES7+",Description="Modern javascript dersleri ile (ES6 & ES7+) Nodejs, Angular, React ve VueJs için sağlam bir temel oluşturun.(50 saat)",Price=120,Image="https://images.pexels.com/photos/614117/pexels-photo-614117.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Javascript dilini etkin bir şekilde kullanabileceksiniz. Ve en önemlisi NodeJs , Angular ,React ve VueJs ile uygulama geliştirebilecek bir alt yapıya sahip olacaksınız. ES5, ES6 ve ES7 arasındaki farklılıkları öğrenecek. Javascript ile Object Oriented Programlamayı, Prototype Yapısını ve ES6 Sınıflarını öğreneceksiniz."},
        new Product{Id=4,Name="React JS : Uygulamalı React JS -Redux Eğitimi",Description="React 18 - React Component - React State - React Hooks - React Router 6 - React Typescript - Redux Toolkit - Context Api (35 saat)",Price=300,Image="https://images.pexels.com/photos/4164418/pexels-photo-4164418.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="React Js Kullanarak Etkili Projeler Yapmayı Öğreneceksiniz, React Hooks Kullanımını, React Js İle Projeler Yapmayı, React Bootstrap Kullanımını,React-Redux Yapısını"},
        new Product{Id=5,Name="Python | Sıfırdan İleri Seviye Programlama",Description="Python ve Programlama Öğrenin. Django , Web Geliştirme , Veri Analizi (Pandas , Numpy), Selenium (80 saat)",Price=200,Image="https://images.pexels.com/photos/1181671/pexels-photo-1181671.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Python'ın ve Programlamanın Temellerini iyi bir şekilde öğrenmiş olacaksınız. Python ile Örümcek Türü yazılımlar geliştirebilecek hale geleceksiniz. Kurs boyunca oldukça fazla program yazacağımız için, kurstan sonra algoritma yeteneğinizin bir hayli geliştiğini farkedeceksiniz."},
        new Product{Id=6,Name="Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti", Description="C# programlama mantığını modüler bir müfredat aracılığıyla projeler geliştirerek öğrenin! (100 saat)", Price=350,Image="https://images.pexels.com/photos/1181671/pexels-photo-1181671.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",value=1,Education="Nesne Tabanlı Programlama'nın (Object Oriented Programming) inceliklerini, 2D oyun altyapılarına adım atmayı, Stok takip sistemleri algoritması kurabilmeyi, Veri tabanı kayıt uygulamaları kontrol edebilmeyi"},

    };
    public static List<Basket> Baskets = new List<Basket>{
        new Basket{Id=1,UserId=1,ProductId=1,Quantity=1},
        new Basket{Id=2,UserId=1,ProductId=2,Quantity=1},
        new Basket{Id=3,UserId=1,ProductId=3,Quantity=1}
    };

}