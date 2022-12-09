window.onload = () => {
    for (var i = 0; i < 10; i++) {
        var Újelem = document.createElement("div")
        Újelem.classList.add("sor")
        document.getElementById("Pascal").appendChild(Újelem)
        for (var o = 0; o <= i; o++) {
            var Mégegydiv = document.createElement("div")
            Mégegydiv.classList.add("elem")
            Mégegydiv.innerHTML = `${faktoriálisR(i)/(faktoriálisR(o)*faktoriálisR(i-o))}`
            Újelem.appendChild(Mégegydiv)
        }
    }
}
var faktoriálisR = (n) => {
    if (n === 0 || n === 1) {
        return 1;
    } else {
        return n * faktoriálisR(n - 1)
    }
}
