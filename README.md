📦 Product Management System - N-Tier Architecture
Bu proje, C# programlama dili ve Entity Framework altyapısı kullanılarak, Katmanlı Mimari (N-Tier) prensiplerine uygun olarak geliştirilmiş bir Ürün ve Kategori yönetim sistemidir.

🏗️ Mimari Yapı
Proje, kodun sürdürülebilirliği ve test edilebilirliği için 4 ana katmana ayrılmıştır:

Presentation Layer: WinForms arayüzü ve kullanıcı etkileşimi.

Business Layer: Manager sınıfları üzerinden iş mantığı ve doğrulama süreçleri.

Data Access Layer: EntityFramework tabanlı veri erişim ve CRUD operasyonları.

Entity Layer: Veritabanı tablolarını temsil eden POCO sınıfları.

🚀 Özellikler
Gelişmiş Listeleme: Ürünlerin kategorileriyle birlikte ilişkisel olarak listelenmesi.

Interface-Based Design: Servis ve Veri Erişim katmanlarında arayüz (Interface) kullanımı.

CRUD İşlemleri: Ürün ve Kategori bilgilerini ekleme, silme, güncelleme ve ID tabanlı sorgulama.

Dinamik Veri Bağlama: ComboBox üzerinden otomatik kategori eşleşmesi.

💾 Kurulum
SQL Server üzerinde gerekli veritabanını oluşturun.

DataAccessLayer içerisindeki Context dosyasında veya App.config içinde yer alan bağlantı adresini (Connection String) kendi SQL sunucunuza göre düzenleyin.

Visual Studio üzerinden bağımlılıkları yükleyerek projeyi çalıştırın.

📸 Uygulama Ekran Görüntüleri
