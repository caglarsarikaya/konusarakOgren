# konusarakOgren

Merhabalar!

Attığınız proje ile neler yapabildiğimi ölçmek istediğiniz için, bildiğim tüm teknolojileri kullanmak istedim ancak süre ile paralel ilerleyiş olması gerektiği için çoğu noktada kaliteye değil, işi bitirmeye odaklandım.

Benden bir müşteri gerçekten böyle bir projeyi 3 gün içerisinde istemiş olsa tam olarak aynısını yapabilirdim. Literatürde mvp olarak geçen en kısa zamanda ortaya ürün koyup sonrasında güncelleyerek devam etmek mantığı ile çalıştım.

Katmanlı mimari kullanmayı seçtim, dependency injeciton önlemek için malesef projemde önüne geçemediğim noktalar var. Her fonksiyonu generic oluşturmak yerine ortaya çalışan birşey koymak için çalıştım.

Veritabanında code first kullandım. Normalde dbfirst yazmayı tercih ederim, schaffold kullanmadan. net core orm ile db ile haberleşmeyi yeğliyorum. Veritabanı üzerindeki etkinliğimi arttıyor. Ancak hızlı ve portatif olması için bu şekilde yapmadım. Model builder üzerinde bir db var. (01)Data access katmanı içinde onu kurarak devam edebilirsiniz.

Buna ek olarak html kodları indirdiğimiz için inputlara backende geçerken güvenliği açığı oluşturuyor. Sourunu çözmek adına verilerin kontrolunu kapattım. Güvenlik 0 ama, ayrıca token ile giriş yada admin hesabını şifrelemeyerek veritabanında da tutmadım.

Eğer sormak istediğiniz bir şey olursa caglarcansarikaya@gmail.com üzerinden ulaşabilirsiniz.

