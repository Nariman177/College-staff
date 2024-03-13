function setPlusIcon(){
  var li = document.getElementsByTagName('li');
  for(var k = 0; k<=li.length-1; k++){
    for(var i = 0; i<= li[k].children.length-1; i++){
      if(li[k].children[i].tagName == 'Ul'){
          li[k].children[i].parentElement.classList.add('with-list');
      }
    }
  }
  document.addEventListener("click", aClick, false);
}
document.addEventListener("DOMContentLoaded", setPlusIcon);
function aClick(e){
  if(e.target.tagName == 'A'){
    var li = e.target.parentElement; //li
    for(var i = 0; i<=li.children.length - 1; i++){
      if(li.children[i].tagName == 'UL'){
        e.preventDefault();
        li.children[i].parentElement.classList.toggle('active');
      }
    }
  }
}
