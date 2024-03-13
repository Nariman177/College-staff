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
