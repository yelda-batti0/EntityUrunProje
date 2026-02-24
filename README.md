🛒 Ürün Yönetim Sistemi (Product Management System)

Bu proje, C# Windows Forms, SQL Server ve Entity Framework kullanılarak geliştirilmiş bir ürün yönetim sistemi uygulamasıdır. Kullanıcı giriş sistemi, kategori yönetimi, ürün yönetimi ve istatistiksel verileri görüntüleme özelliklerini içerir.

Uygulama temel olarak CRUD işlemleri (Create, Read, Update, Delete) ve veritabanı bağlantısı pratiği yapmak amacıyla geliştirilmiştir.

🚀 Özellikler
🔐 Kullanıcı Giriş Paneli

Kullanıcı adı ve şifre ile giriş yapılır

Kullanıcı bilgileri SQL veritabanında tutulur

Doğrulama sonrası ana panele yönlendirme yapılır

📂 Kategori İşlemleri

Kategori ekleme

Kategori silme

Kategori güncelleme

DataGridView ile kategori listeleme

Kategori ID ve Kategori Adı yönetimi

📦 Ürün İşlemleri

Ürün ekleme

Ürün silme

Ürün güncelleme

Ürünleri DataGridView ile listeleme

ComboBox ile kategori seçimi

Ürün–kategori ilişkisi yönetimi

📊 İstatistik Paneli

Veritabanındaki güncel verilere göre:

Toplam kateogri sayısı

Toplam ürün sayısı

Aktif müşteri sayısı

Pasif müşteri sayısı

Beyaz Eşya Sayısı

Toplam stok

En yüksek fiyatlı ürün

En düşük fıyatlı ürün

Şehir sayısı

Kasadaki Tutar

En fazla ürünlü marka

Tablo verilerine göre anlık istatistikler


🛠 Kullanılan Teknolojiler

C#

Windows Forms

SQL Server

Entity Framework (Database First)

ADO.NET

LINQ

DataGridView

ComboBox Veri Bağlama

🗄 Veritabanı Yapısı

Projede SQL Server üzerinde oluşturulan tablolar:

Kategoriler

Urunler

Kullanicilar

Satislar

Musteriler (istatistik hesaplamaları için)

Veritabanı üzerinde örnek veri kayıtları bulunmaktadır.

⚙ Kurulum

Projeyi çalıştırmak için:

Repoyu klonlayın:

git clone https://github.com/yelda-batti0/EntityUrunProje.git

SQL Server üzerinde veritabanını oluşturun.

Connection string'i kendi SQL Server ayarınıza göre güncelleyin.

Projeyi Visual Studio ile açıp çalıştırın.

🎯 Projenin Amacı

Bu proje aşağıdaki konuları öğrenmek/pratik yapmak için geliştirilmiştir:

Katmanlı uygulama mantığı

Veritabanı işlemleri

Entity Framework kullanımı

CRUD operasyonları

Windows Forms arayüz geliştirme

Veri bağlama işlemleri

İstatistiksel veri çekme

 Geliştirici

Yelda Battı
