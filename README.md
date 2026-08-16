# 🔐 Yetki

[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Category](https://img.shields.io/badge/Category-Authorization-6f42c1)](#proje-amaci)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D4?logo=windows&logoColor=white)](https://www.microsoft.com/windows)

**Yetki**, uygulamalarda kullanıcı erişimi ve yetkilendirme mantığını incelemeye yönelik bir örnek projedir.

## 🎯 Proje Amacı

Kullanıcı, rol ve izin kavramlarının uygulama içinde nasıl modellenebileceğini göstermek.

## 🔑 Temel Kavramlar

```text
Kullanıcı
   ↓
Rol
   ↓
İzin
   ↓
Kaynak / Menü / İşlem
```

## 🧰 Teknolojiler

- C#
- .NET
- Windows masaüstü geliştirme
- Yetkilendirme/RBAC yaklaşımı

## 🚀 Kurulum

```bash
git clone https://github.com/ebubekirbastama/yetki.git
```

Projeyi Visual Studio ile açıp derleyin. Veritabanı kullanılıyorsa bağlantı ayarlarını güvenli şekilde yapılandırın.

## 🔐 Güvenlik

- Parolaları düz metin saklamayın.
- Yetkileri deny-by-default yaklaşımıyla tasarlayın.
- Kullanıcı girdilerini doğrulayın.
- Hassas işlemleri loglayın.

## 🛣️ Geliştirme Fikirleri

- RBAC
- Permission-based authorization
- SQLite/SQL Server
- Audit log
- Session management
- Güvenli parola hashleme
- Unit/integration testleri

## 👨‍💻 Geliştirici

**Ebubekir Bastama**  
GitHub: https://github.com/ebubekirbastama
