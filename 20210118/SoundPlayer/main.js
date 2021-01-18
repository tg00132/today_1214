// javaScript는 ''와 ""모두 문장 정의에 사용됨
// 'load'
// "load"

// java
// char a = 'a'
// String b = "kkk";

// window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
// 398p
// 많이 쓰이는건 document 객체를 많이 씀
window.addEventListener('load',
function() 
{
    // alert("안녕하세요");

    //클래스명이 sound인 것을 모두 선택함(=불러옴)
    const sounds = document.querySelectorAll(".sound");
    
    //클래스 명이 pads인 태그의 후손중에서 div태그들 모두 불러옴
    const pads = document.querySelectorAll(".pads div");

    //클래스 이름이 visaul태그 하나 선택
    const visual = document.querySelector('.visual');
    
    //클래스 이름이 title인 태그 하나 선택
    const title = document.querySelector('.title');

    // 초기화 할때 쓰임
    const colors = 
    [" magenta", "lime", "yellow", "springgreen", "red", "aqua"];

    //재생되는 음악이 끝나면, .visaul에서 비쥬얼과 제목 제거

    sounds.forEach(
        function (snd) {
            snd.onended = function(){ 
        
            visual.innerHTML = "";
            title.innerHTML = "";
            }
        }    
    );

    pads.forEach( function(pad, index) {
        pad.addEventListener('click', function(){
            //기존에 재생되는 음악을 중지 시켜야 한다.
           sounds.forEach(function(inx) {
            //console.log(inx);
            inx.pause();
           });
           if(sounds[index]){
            sounds[index].currentTime = 0;
            sounds[index].play();

            //뮤직 제목을 출력해 준다.
            //console.log(sounds[index].src) ;
            const strArray = sounds[index].src.split("sound/");
            title.innerHTML = strArray[1];
           }
           
            //볼만들고 애니메이션 하기
            createBubbles(index);
        });
    });

    const createBubbles = function(index)
    {
        visual.innerHTML="";
        //div 태그 생성
        const bubble = document.createElement("div");
        //visual 태그 안에 div 태그 하나 집어넣는다.
        visual.appendChild(bubble);
        bubble.style.backgroundColor = colors[index];
        bubble.style.top = '300px';
        bubble.style.animation = 'animation 2000ms linear infinite both';
    }
})