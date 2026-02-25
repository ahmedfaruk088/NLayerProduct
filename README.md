
#Product Management System (N-Tier Architecture)

Bu proje, ürün ve kategori yönetimini sağlamak amacıyla Katmanlı Mimari (N-Tier Architecture) kullanılarak geliştirilmiş bir Windows Forms uygulamasıdır. Kod yapısı, iş mantığı ve veri erişim süreçlerinin birbirinden tamamen ayrıldığı, bakımı kolay ve genişletilebilir bir yapı sunar.

#🏗️ Mimari Detaylar

Proje 4 ana katmandan oluşmaktadır:
#Entity Layer (Varlık Katmanı): Veritabanındaki tabloları temsil eden Product ve Category gibi sınıfların bulunduğu katmandır.
#Data Access Layer (DAL - Veri Erişim Katmanı): Entity Framework kullanılarak veritabanı CRUD işlemlerinin yapıldığı katmandır. EFProductDal gibi sınıflar üzerinden veritabanı sorguları yönetilir.
#Business Layer (BL - İş Mantığı Katmanı): Uygulamanın kontrol merkezidir. ProductManager gibi sınıflar, arayüzden gelen istekleri doğrular ve veri katmanına iletir.
#Presentation Layer (PL - Sunum Katmanı): Kullanıcının etkileşime girdiği WinForms arayüzüdür. Bu katman sadece Service arayüzlerini (Interface) tanır, işin mutfağındaki detayları bilmez.

#🛠️ Teknik Özellikler & Desenler
C# & .NET Framework

Entity Framework: Veritabanı yönetim sistemi olarak kullanıldı.
Interface-Based Design: IProductService ve IProductDal gibi arayüzler sayesinde katmanlar arası bağımlılık minimize edildi (Loosely Coupled).
Generic Repository Pattern: Ortak CRUD işlemleri merkezi bir yapıda toplandı.
Linq Sorguları: TGetProductsWithCategory gibi metotlarla ilişkili tablolar üzerinde gelişmiş sorgulamalar yapıldı

#✨ Uygulama Yetenekleri
Ürün Yönetimi: Ekleme, silme, güncelleme ve ID'ye göre getirme.
Kategori Entegrasyonu: Ürünler eklenirken veya güncellenirken dinamik kategori seçimi (ComboBox).
İlişkisel Listeleme: Ürünleri bağlı oldukları kategori bilgileriyle birlikte görüntüleme.

#📸 Uygulama Ekran Görüntüleri:
