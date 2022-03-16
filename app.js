const cards = [
    '#zebra', '#leao', '#jacare', '#elefante'
];

//FUNCTIONS
function shake(element, distance, time) {
    if (typeof element === 'string') {
        element = document.querySelector(element);
    }
    if (!time) time = 500;
    if (!distance) distance = 5;

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

