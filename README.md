# 🚀 Tasarım Desenleri Eğitimi
Bu repository, Murat Yücedağ'ın Udemy'de bulunan Asp.Net Core 6.0 ile Design Patterns kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core 5.0 ve 6.0 (MVC)), MS SQL Server ve PostgreSQL gibi farklı teknolojilerle tasarım desenlerini tek katmanlı basit projelerle öğrenmeye çalıştım. Bu proje temel yazılım tasarım desenlerini öğrenmek ve uygulamak amacıyla geliştirilmiştir. Her tasarım deseni için küçük, anlaşılır örnek projeler oluşturulmuş ve pratik olarak uygulanmıştır.

## Tasarım Deseni Nedir?
Tasarım deseni (design pattern), yazılım geliştirme sırasında sıkça karşılaşılan problemler için önceden düşünülmüş, test edilmiş ve tekrar kullanılabilir çözüm şablonlarıdır.
- "Şablon" derken kast edilen şey, hazır bir kod parçası değil, uygulanabilecek bir fikir, yaklaşım veya yapıdır.
- Yani tasarım desenleri ne yapman gerektiğini değil, nasıl yapabileceğini tarif eder.

Örneğin: Bir uygulamada tek bir nesnenin tüm sistemde kullanılmasını istiyorsun (ör. veritabanı bağlantısı). Her yerde yeni bağlantı nesnesi oluşturmak yerine Singleton tasarım deseni kullanırsın.

### 📌 Temel Özellikler
- Tekrar kullanılabilir — Birçok projede benzer yapıda uygulanabilir.
- Standartlaştırır — Ekibe aynı dili konuşma imkanı verir (“Burada Observer kullanmışız” dediğinde herkes anlar).
- Bakımı kolaylaştırır — Çözümler önceden denenip test edildiği için hata riski azalır.
- Kod okunabilirliğini artırır — Karmaşık yapılar daha anlaşılır hale gelir.

### 🔹 Kategorileri
Genelde üç ana grupta incelenir:
1. Creational (Oluşturucu) Desenler → Nesne oluşturma süreçlerini yönetir.
Örnek: Singleton, Factory, Builder, Prototype
2. Structural (Yapısal) Desenler → Nesneler arasındaki yapıyı organize eder.
Örnek: Adapter, Facade, Decorator, Composite
3. Behavioral (Davranışsal) Desenler → Nesneler arası iletişim ve davranış yönetimini sağlar.
Örnek: Observer, Strategy, Command, State

### 📍 Kısa Tanım:
Tasarım deseni = “Aynı sorun için tekrar tekrar tekerleği icat etmek yerine hazır bir yol haritası”.
<br> <br>

---

## 📌 Projenin Amacı
- Yazılım geliştirme sürecinde **tasarım desenlerini** anlamak.
- Bu desenlerin **hangi problemleri çözdüğünü** ve **nasıl uygulandığını** görmek.
- ASP.NET Core ortamında **katmanlı yapı**, **Dependency Injection** ve **Entity Framework Core** gibi teknolojilerle birlikte tasarım desenlerini kullanmak.

---

## 📂 Kullanılan Tasarım Desenleri
Aşağıda projede uygulanan tasarım desenleri ve kısa açıklamaları yer almaktadır:

### 1. **Chain of Responsibility**
- **Amaç:** Bir isteğin bir zincir halinde farklı nesneler tarafından işlenebilmesini sağlar.
- **Örnek:** Gelen bir isteğin sırasıyla farklı onay aşamalarından geçirilmesi.

### 2. **CQRS (Command Query Responsibility Segregation)**
- **Amaç:** Veri okuma ve yazma işlemlerini ayırarak sistemin daha anlaşılır ve yönetilebilir olmasını sağlar.
- **Örnek:** `Get` işlemleri için Query Handler, `Add/Update/Delete` işlemleri için Command Handler kullanımı.

### 3. **Template Method**
- **Amaç:** Algoritmanın iskeletini tanımlar, alt sınıfların sadece gerekli adımları özelleştirmesine izin verir.
- **Örnek:** Rapor oluşturma sürecinde genel şablon aynı kalırken, veri kaynakları farklı olabilir.

### 4. **Observer**
- **Amaç:** Bir nesnede olan değişiklikleri otomatik olarak diğer ilgili nesnelere bildirir.
- **Örnek:** Kullanıcı kaydı sonrası farklı servislerin (mail, log vb.) tetiklenmesi.

### 5. **Unit of Work (UoW)**
- **Amaç:** Birden fazla repository ile çalışırken işlemleri tek bir işlem (transaction) olarak yönetmek.
- **Örnek:** Sipariş ekleme sırasında hem sipariş hem sipariş detayı hem de stok güncellemenin tek transaction içinde yapılması.

### 6. **Repository**
- **Amaç:** Veri erişim kodunu soyutlamak ve tekrar kullanılabilir hale getirmek.
- **Örnek:** Tüm veri tabanı CRUD işlemlerini repository katmanında toplamak.

### 7. **Composite**
- **Amaç:** Nesneleri ağaç yapısında temsil etmek, hem tekil hem de grup nesnelerle aynı şekilde çalışabilmek.
- **Örnek:** Kategori ve alt kategori yapısının tek model üzerinden yönetilmesi.

### 8. **Mediator**
- **Amaç:** Nesneler arası doğrudan iletişimi engelleyerek iletişimi bir aracı (mediator) üzerinden yapmak.
- **Örnek:** Farklı modüllerin birbiriyle haberleşmesini Mediator sınıfı ile yönetmek.

### 9. **Iterator**
- **Amaç:** Koleksiyonların elemanlarını, koleksiyonun iç yapısını bilmeden sırayla gezebilmek.
- **Örnek:** Ziyaret edilecek yerler listesini Iterator ile dolaşmak.

### 10. **Facade**
- **Amaç:** Karmaşık alt sistemleri tek bir basit arayüz üzerinden kullanmak.
- **Örnek:** Sipariş tamamlama sürecinde stok düşme, sipariş ekleme, sipariş detayı ekleme işlemlerini tek bir metot ile yapmak.

### 11. **Decorator**
- **Amaç:** Bir nesneye dinamik olarak yeni sorumluluklar eklemek.
- **Örnek:** Farklı ödeme sistemlerini süsleyerek ek güvenlik katmanları eklemek.

---

## 🛠 Kullanılan Teknolojiler
- 💻 **ASP.NET Core Web App**
- 🗄 **Entity Framework Core**
- 🛢 **MSSQL Server**
- 🐘 **PostgreSQL**
- 🎨 **Bootstrap 5**
- 🧩 **Tasarım Desenleri (Design Patterns)**

---

## 📂 Uygulanan Tasarım Desenleri
- 🔗 **Chain of Responsibility** – İstekleri zincir şeklinde işleme.
- 📄 **CQRS** – Okuma ve yazma operasyonlarını ayırma.
- 🧬 **Template Method** – Algoritma iskeleti tanımlama.
- 👀 **Observer** – Değişiklikleri ilgili nesnelere bildirme.
- 📦 **Unit of Work (UoW)** – Tüm işlemleri tek transaction’da toplama.
- 📚 **Repository** – Veri erişim katmanını soyutlama.
- 🌳 **Composite** – Ağaç yapısında nesnelerle çalışma.
- 🤝 **Mediator** – Nesneler arası iletişimi aracı ile sağlama.
- 🔍 **Iterator** – Koleksiyon elemanlarını sırayla gezme.
- 🏢 **Facade** – Karmaşık sistemi tek basit arayüzle yönetme.
- 🎀 **Decorator** – Dinamik olarak yeni özellikler ekleme.

---

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Vitrin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/HotelierAPI/blob/33ebd051ef314a3783e9df68ebd99ad16ce7cb16/ss/localhost_47007_Default_Index.png" alt="image alt">
</div>
