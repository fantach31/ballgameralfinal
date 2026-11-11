Batuhan Arda Günbatı 2602020019

Bir topu yöneterek oynadığımız üç bölümden oluşan bir oyun. Amacımız yeşil topları toplayıp engellerden uzak durarak üç bölümü tamamlamak.

Kullanılan scriptler -

AudioManager: Oynatılacak olan bütün seslerin fonksiyonlarının bulunduğu yer. Oynatılmalarını diğer scriptler tetikler.
PlayerManager: Oyuncunun hareket/zıplama kodları ve çarpışma fonksiyonları burada bulunur.
SceneManager: Belirli bir skor karşılanıyorsa diğer sahnelere(bölümlere) geçmeyi sağlayan script.
ScoreManager: Oyuncuya skor verilmesi, azaltılması ve bunun ekranda gösterimi burada gerçekleşir. PlayerManager buradaki fonksiyonları tetikler.

Sahne geçişi algoritmasının açıklaması (yukarıdan aşağı): 

"SceneManager" scriptinde "requiredScore" isimli bir değişken bulunur, her bir bölüm atladığımızda bu değer o bölüme göre değişecektir.
Oyuncu "LevelPortal" nesnesiyle temas ettiğinde "SceneManager" oyuncunun mevcut skoruyla o bölümün "requiredScore" değerini karşılatırıyor.

Eğer oyuncu yeterli skora sahip değilse "Başarısız. Gereken puan: {requiredScore}" şeklinde bir mesaj çıktı olarak gönderiliyor.

Eğer oyuncu yeterli skora sahipse kodun daha altında bulunan NextLevel() fonksiyonu tetikleniyor. Burada iki değişkenimiz var:
"currentScene" ve "nextScene". currentScene şu anda oyuncunun bulunduğu sahneye atanan numara, nextScene ise bu numaraya +1 eklenen değer. (yani sıradaki sahne)
Eğer oyuncunun bulunduğu bölüm son bölümse ve başarıyla tamamlanırsa oyuncu "Oyunu kazandın!" mesajını çıktı olarak alır.
Ama eğer hala bitirilmesi gereken bölüm(ler) varsa "Seviye {currentScene} başarıyla geçildi!" çıktısı alınır.

Oyuncu tüm bölümleri tamamladığında oluşturduğum 4. bölüme ışınlanır. Burası ekranda "You win!" yazan basit bir alandır. Toplanabilecek tonla yeşil top bulunur.

Karşılaşılan bir hata:

Test ederken keşfettiğim bir hatada yeşil topları toplamama ve gereken skora ulaşmama rağmen portaldan geçemememe neden oluyordu.
Yeşil topları kontrol ettim ve onlarda bir sorun yoktu. Sesler, skor tetikleme ve diğer herşey düzgündü. 
Daha sonrasında fark ettim ki ScoreManager yanlışlıkla iki GameObjecte aynı anda atanmıştı. Buda garip bir şekilde sistemin bazen düzgün bazen bozuk çalışmasına neden oluyordu.

