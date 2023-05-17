const img = document.querySelector("img");
const title = document.querySelector("h2");
const text = document.querySelector("p");
const dots = [...document.querySelectorAll("svg")];

let index = 0;
dots[0].style.fill = "black";
dots[0].style.stroke = "black";

const pikaso = [
    {
        title: "Жена која плаче",
        text: "Жена која плаче из 1937. године представља неку врсту наставка Гернике. Док Герника осликава погром у тренутку док се страдање догађа, Жена која плаче истражује емотивне последице рата, из угла једне од жена насликаних у Герници.",
    },
    {
        title: "Гертруда Стајн",
        text: "Портрет америчке књижевнице Гертруде Стајн из 1905-06. године  представља дело које хронолошки припада завршетку Пикасове ружичасте фазе.",
    },
    {
        title: "Стари гитариста",
        text: "Настала у техници уља на платну, слика припада Пикасовој такозваној плавој фази, названој по уметниковој техници да користи искључиво нијансе плаве боје, како би што боље осликао теме људског сиромаштва и патње.",
    },
    {
        title: "Девојка пред огледалом",
        text: "Ако за неко дело може да се каже да је типично пикасовско онда је то Девојка пред огледалом из 1932. године, са својим живахним колоритом, дахом еротицизма и заводљивим облицима који кубизам претварају у екстрем.",
    },
    {
        title: "Портрет Амброаза Волара (1910)",
        text: "Слика је приказ утицајног трговца уметнинама Амброаза Волара, који је одиграо важну улогу у Пикасовој раној уметничкој каријери.",
    },
];

const handleIndex = () => {
    if (index === 4) index = 0;
    else {
        index++;
    }
};

setInterval(() => {
    img.classList.add = "fade";
    dots.forEach((dot) => {
        dot.style.fill = "gray";
        dot.style.stroke = "gray";
    });
    console.log(index);
    handleIndex();
    title.innerText = pikaso[index].title;
    text.innerText = pikaso[index].text;
    img.src = `./slike/slika${index + 1}.jpg`;
    dots[index].style.fill = "black";
    dots[index].style.stroke = "black";
    img.classList.remove = "fade";
}, 3000);
