# WooxTravel
#### Bu proje, M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ eğitmenliğinde verilen ödev kapsamında geliştirilmiş olup, ASP.NET MVC kullanılarak yapılan 2. projedir.
# ✨ Genel Bakış
### 👤 Kullanıcı Arayüzü
##### Kullanıcı arayüzü, görsel ve işlevsel olarak kullanıcı deneyimini geliştirmek için tasarlandı. Anasayfadaki dinamik slider, veritabanından son eklenen 4 destinasyonu otomatik olarak yükler ve hem otomatik geçiş hem de manuel kontrol imkanı sunar. Slider üzerindeki “İncele” butonu, kullanıcıları destinasyonların detay sayfasına yönlendirir. Slider'ın hemen altında yer alan destinasyon listesi, sayfalama sistemiyle yapılandırılmış olup içeriklere kolay erişim sağlar. Ayrıca, rezervasyon işlemleri için tasarlanan pop-up, telefon numarası girişlerinde maskeleme özelliğiyle doğruluk ve kullanım kolaylığı sunar. Bu özellikler, kullanıcıların sistemi hızlı ve verimli bir şekilde kullanmasını mümkün kılar.
### 🔐 Admin Paneli
##### Admin paneli, yöneticilerin sisteme eksiksiz ve güvenli bir şekilde erişim sağlaması için tasarlanmıştır. Giriş ekranı, yalnızca doğru kullanıcı adı ve şifre kombinasyonuyla erişim sağlanacak şekilde yapılandırılmıştır. Başarılı girişin ardından yöneticiler, sol menü üzerinden kategori, destinasyon ve rezervasyon yönetimi gibi temel CRUD işlemlerini kolayca gerçekleştirebilirler. Sağ üst köşede yer alan mesaj alanında, giriş yapan kullanıcıya atılan mesajlar görüntülenir. Admin paneli ayrıca, Chart.js kullanılarak oluşturulmuş 4 farklı grafik türüyle zenginleştirilmiş bir analiz sayfası sunar ve widget yapısıyla belirlenen 12 farklı istatistiği görselleştirir. Destinasyon ekleme işlemlerinde SweetAlert ile başarılı bir şekilde tamamlandığına dair bildirim yapılır. Mesajlar sayfasında bir mesaj açıldığında, detayları pop-up üzerinde görüntülenir. Ek olarak, rezervasyon işlemlerinde kullanılan kredi kartı ekranı, girilen kart numarası, son kullanma tarihi ve isim gibi bilgileri gerçek zamanlı olarak kart görseline yansıtarak kullanıcılara görsel bir doğrulama sağlar. Logout özelliği tamamlanmış olan bu panel, modern bir yönetim deneyimi sunarken kullanıcılar için kolaylık ve etkileşim sağlar.
### Kullanılan Teknolojiler ve Uygulamalar
- 🌐 ASP.NET MVC
- 💻 Entity Framework (Code First): Veritabanı yönetimi.
- 💽 Microsoft SQL Server (MSSQL): Güçlü bir veritabanı altyapısı.
- 🎨 HTML, CSS, Bootstrap
- 📊 Chart.js: Grafiksel veri analizi için (Line, Bar, Pie, Doughnut).
- 🚨 SweetAlert
- ✅ LINQ ve JavaScript
- 📩 Modal & Pop-Up
- 📈 Dinamik Veriler için Widget Yapısı
- 💳 3D Kredi Kartı Ödeme Tasarımı
- ⚙️ JavaScript (JS) ve LINQ ile Dinamik İşlemler
# ✨ Veritabanı Diyagramı
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/database_diagram.png)
# ✨ Kullanıcı Arayüzü
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/destination_anasayfa.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/destination_detail.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/rezervasyon_popup.png)
# ✨ Admin Paneli
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/login_sayfas%C4%B1.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/profil_d%C3%BCzenleme.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/destination.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/destination_update.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/sweetalert.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/categories.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/charts.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/statistics.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/gelen_mesajlar.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/creditcard2.png)
![](https://github.com/selin-krsli/WooxTravel/blob/master/WooxTravel/Content/Proje2_Ekran_Goruntuleri/creditcard3.png)
