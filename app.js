const shakeBtn = document.querySelector('.shake-btn');
const fadeBtn = document.querySelector('.fade-btn');
const showBtn = document.querySelector('.show-btn');

//FUNCTIONS
function shake(element, distance, time) {
    if (typeof element === 'string') {
        element = document.getElementById(element);
    }
    if (!time) time = 500;
    if (!distance) distance = 5;

    if(element.style.opacity === '0') return;

    const originalStyle = element.style.cssText;
    element.style.position = 'relative';
    let start = (new Date()).getTime();

    animate();

    function animate() {
        let now = (new Date()).getTime();
        let elapsed = now - start;
        let fraction = elapsed / time;

        if (fraction < 1) {
            let x = distance * Math.sin(fraction * 4 * Math.PI);
            element.style.left = x + 'px';

            setTimeout(animate, Math.min(25, time - elapsed));
        } else {
            element.style.cssText = originalStyle;
        }
    }

}

function fadeOut(element, time){
    if(typeof element === 'string'){
        element = document.getElementById(element);
    }
    if(!time) time = 500;

    if(element.style.opacity === '0') return; 
    
    let ease = Math.sqrt;
    let start = (new Date()).getTime();

    animate();

    function animate(){
        let elapsed = (new Date()).getTime() - start;
        let fraction = elapsed / time;
        if(fraction < 1){
            let opacity = 1 - ease(fraction);
            element.style.opacity = String(opacity);
            setTimeout(animate, Math.min(25, time - elapsed));
        }else{
            element.style.opacity = '0';
        }
    }

}

function makeVisible(element){
    if(typeof element === 'string'){
        element = document.getElementById(element);
    }
    element.style.opacity = '1';
}

//EVENTS
shakeBtn.onclick = () => {
shake('zebra', 10, 600);
shake('leao', 10, 600);
shake('elefante', 10, 600);
shake('jacare', 10, 600);

shake('arara', 10, 600);
shake('tigre', 10, 600);
shake('macaco', 10, 600);
shake('girafa', 10, 600);
};

fadeBtn.onclick = ()=>{
    fadeOut('zebra', 500);
    fadeOut('leao', 500);
    fadeOut('elefante', 500);
    fadeOut('jacare', 500);

    fadeOut('macaco', 500);
    fadeOut('arara', 500);
    fadeOut('tigre', 500);
    fadeOut('girafa', 500);
}

showBtn.onclick = ()=>{
    makeVisible('zebra');
    makeVisible('leao');
    makeVisible('elefante');
    makeVisible('jacare');

    makeVisible('macaco');
    makeVisible('tigre');
    makeVisible('girafa');
    makeVisible('arara');
};