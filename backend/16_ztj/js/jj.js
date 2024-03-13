function scoreGame() {
    var score = decodeURIComponent(location.search.substr(1)).split('&');
    score.splice(0, 1);
    var result = score[0];
    console.log(result);
    document.getElementById("result").innerHTML = result;
}
