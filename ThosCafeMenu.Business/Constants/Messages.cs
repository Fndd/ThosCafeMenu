using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThosCafeMenu.Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "Yetkisiz erişim.";
        public static string UserRegistered = "Kullanıcı kaydınız oluşturuldu. Giriş sayfasına yönlendiriliyorsunuz.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string UserAlreadyExists = "Kullanıcı kaydı daha önce oluşturuldu.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string SuccessfulLogin = "Kullanıcı girişi başarılı.";

        public static string CategoryAdded = "Kategori eklendi."; 
        public static string CategoryNameInvalid = "Kategori ismi geçersiz.";
        public static string CategoryDeleted = "Kategori silindi.";
        public static string CategoryUpdated = "Kategori güncellendi.";
        public static string CategorysListed = "Kategoriler listelendi.";
        public static string CategoryListed = "Kategori listelendi.";
        public static string CategoryNameAlreadyExists = "Bu isimde daha önce kategori oluşturuldu.";
        public static string CategoryCountOfCategoryError = "Mevcut kategori sayısı aşıldı.";

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductListed = "Ürün listelendi.";
        public static string ProductNameAlreadyExists = "Bu isimde daha önce ürün oluşturuldu.";
        public static string ProductCountOfCategoryError = "Mevcut ürün sayısı aşıldı.";

        public static string ImageAdded = "Fotoğraf eklendi.";
        public static string ImageTitleInvalid = "Fotoğraf başlığı geçersiz.";
        public static string ImageDeleted = "Fotoğraf silindi.";
        public static string ImageUpdated = "Fotoğraf güncellendi.";
        public static string ImagesListed = "Fotoğraflar listelendi.";
        public static string ImageListed = "Fotoğraf listelendi.";
        public static string ImageNameAlreadyExists = "Bu isimde daha önce fotoğraf oluşturuldu.";
        public static string ImageCountOfCategoryError = "Mevcut fotoğraf sayısı aşıldı.";
    }
}
