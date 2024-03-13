$(function(){
  $('.b1').click(function(){
    $('.modal-window').toggleClass('block');
  });
});

$(function(){
  $('.fa-window-close').click(function(){
    $('.modal-window').toggleClass('block') ;
  });
});

$(function(){
  $('.pay').click(function(){
    $('.payment').toggleClass('block');
  });
});

$(function(){
  $('.fa-solid fa-circle-xmark').click(function(){
    $('.payment').toggleClass('payment block') ;
  });
});
