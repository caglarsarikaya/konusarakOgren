# konusarakOgren

Merhabalar!

Attığınız proje ile neler yapabildiğimi ölçmek istediğiniz için, bildiğim tüm teknolojileri kullanmak istedim ancak süre ile paralel ilerleyiş olması gerektiği için çoğu noktada kaliteye değil, işi bitirmeye odaklandım.

Benden bir müşteri gerçekten böyle bir projeyi 3 gün içerisinde istemiş olsa tam olarak aynısını yapabilirdim. Literatürde mvp olarak geçen en kısa zamanda ortaya ürün koyup sonrasında güncelleyerek devam etmek mantığı ile çalıştım.

Katmanlı mimari kullanmayı seçtim, dependency injeciton önlemek için malesef projemde önüne geçemediğim noktalar var. Her fonksiyonu generic oluşturmak yerine ortaya çalışan birşey koymak için çalıştım.

Veritabanında code first kullandım. Normalde dbfirst yazmak istemiştim,  Veritabanı üzerindeki etkinliğimi arttıyor. Schaffold kullanmadan. net core orm ile db ile haberleşmeyi yeğliyorum. 

Hem veritabanındaki tablolara,prosedürlere(prosedürün bu noktada hem güvenlik hem de hız açısından bence önemi büyük. net core'un prosedurden hızlı çalıştığını savunanlar var aksini savunanlar da var, performans olarak bir sonucum yok ama prosedür ile daha rahat çalışıyorum) hemde front end üzerinde js framework ile bide backend için .net core kod yazacak zamanım yoktu.

Hızlı bitirebilmek ve portatif olması için herşeyi visual studio üzerinde yaptım. Model builder üzerinde bir db var. (01)Data access katmanı içinde onu kurarak devam edebilirsiniz.

Buna ek olarak html kodları indirdiğimiz için inputlara backende geçerken güvenliği açığı oluşturuyor. Sorunu çözmek adına verilerin kontrolunu kapattım. Güvenlik 0 ama, ayrıca token ile giriş güvenliği yada admin hesabını şifreleyerek veritabanında da tutmak gibi başka güvenlik önlemlerimiz de yok.
