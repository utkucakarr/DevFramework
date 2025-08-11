# Eğitim Sürecinde Kullanılan Teknolojiler ve Kavramlar

Bu proje, **Btk Akademi** üzerinden **Engin Demiroğ**’dan almış olduğum C# eğitiminde edindiğim bilgi ve deneyimleri yansıtmak amacıyla hazırlanmıştır. Eğitim süresince yazılım geliştirme yaklaşımlarını ve çeşitli araçları aktif olarak kullandım.

---

## Kullanılan Teknolojiler - Yöntem - Kütüphane vb.

### Yazılım Mimarisi ve Prensipler
- **N-Layer Architecture:** Proje katmanlı mimari prensiplerine uygun olarak yapılandırılmıştır, böylece kodun sürdürülebilirliği ve test edilebilirliği artırılmıştır.
- **SOLID Prensipleri:** Yazılımın esnek, sürdürülebilir ve kolay yönetilebilir olması için SOLID prensiplerine uygun kod yazılmıştır.

### Test ve Validasyon
- **Unit Testing:** Kod kalitesini ve güvenilirliğini sağlamak için birim testler yazılmıştır.
- **Fluent Validation:** Gelişmiş ve okunabilir validasyon işlemleri için Fluent Validation kütüphanesi tercih edilmiştir.
- **Mocking:** Test senaryolarında doğrulama ve izolasyon için Moq kütüphanesi ile validasyon yapılmıştır.

### Veri Yönetimi
- **ORM:** Veritabanı işlemleri için Entity Framework ve NHibernate kullanılmıştır.
- **Mapping:** Veri dönüşümleri için hem manuel mapping yöntemleri hem de AutoMapper kütüphanesi kullanılmıştır.
- **Cache Yönetimi:** Performansı artırmak adına MemoryCache kullanılmıştır.
- **Cache ve Transaction Yönetimi:** Veritabanı işlemlerinde tutarlılığı sağlamak ve performansı artırmak için cache ve transaction mekanizmaları entegre edilmiştir.

### Yazılım Mimarisi ve Yapılandırma
- **Dependency Injection / IoC Container:** Bağımlılıkların yönetimi ve gevşek bağlı yapı için Ninject kullanılmıştır.
- **Aspect Oriented Programming (AOP):** PostSharp ile kesitsel (cross-cutting) konular için aspect tasarımı uygulanmıştır.
- **Cross-Cutting Concerns:** Loglama, hata yönetimi, yetkilendirme ve validation gibi ortak işlemler aspect yapısıyla merkezileştirilmiştir.

### Güvenlik ve Yetkilendirme
- **Authorization:** Proje güvenliği için yetkilendirme mekanizmaları entegre edilmiştir.

### Loglama ve Hata Yönetimi
- **Loglama:** Hem dosya bazlı (File Logger) hem de veritabanı tabanlı (Database Logger) loglama işlemleri Log4Net ile gerçekleştirilmiştir.
- **Exception Handling:** Uygulama genelinde exception yönetimi ve loglama için özel aspectler kullanılmıştır.
