var counter = 1;
setInterval(function(){
  document.getElemenyById?('radio' + counter).cheked=true;
  counter++;
  if(counter > 4){
    counter = 1;

  }
},5000);
