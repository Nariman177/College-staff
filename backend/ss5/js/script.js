$(function(){
  $('.fa-search').click(function(){
    $('.i1').toggleClass('width0');
  });
});


$(function(){
  $('.b1').click(function(){
    $('.modal-window').toggleClass('block');
  });
});

$(function(){
  $('.fa-window-close').click(function(){
    $('.modal-window').toggleClass('block');
  });
});

$(function(){
  $('.d2').click(function(){
    $('.modal-w').toggleClass('block');
  });
});

$(function(){
  $('.fa-solid fa-xmark').click(function(){
    $('.modal-w').toggleClass('block');
  });
});


// Init fancyBox
$().fancybox({
  selector : '.slick-slide:not(.slick-cloned)',
  hash     : false
});

// Init Slick
$(".main-slider").slick({
  slidesToShow   : 1,
  slidesToScroll : 1,
  infinite : true,
  dots     : false,
  arrows   : false,
  responsive : [
    {
      breakpoint : 960,
      settings : {
        slidesToShow   : 1,
        slidesToScroll : 1
      }
    }
  ]
});
