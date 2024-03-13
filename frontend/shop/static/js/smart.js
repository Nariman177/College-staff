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
    $('.modal-window').toggleClass('block');
  });
});

$(function(){
  $('.fa-solid fa-circle-xmark').click(function(){
    $('.payment').toggleClass('payment block') ;
  });
});

$(function() {
  $('.pay').click(function() {
    // Получаем информацию о товарет
    var title = $(this).siblings('h4').text();
    var price = $(this).siblings('.dollor').text();
    var description = $(this).siblings('ol').children('p').text();
    var imageSrc = $(this).siblings('img').attr('src');

    // Создаем новый элемент для корзины
    var basketItem = $('<div>').addClass('basket');
    var basketPrice = $('<div>').addClass('lor').text(price);
    var basketImage = $('<img>').attr('src', imageSrc);
    var basketDescription = $('<div>').addClass('tt').html('<p>' + description + '</p>');
    var basketDeleteButton = $('<button>').addClass('delete').text('Удалить');
    var basketBuyButton = $('<button>').text('Купить');

    // Добавляем элементы в корзину
    basketItem.append(basketPrice, basketImage, basketDescription, basketDeleteButton, basketBuyButton);
    $('.modal-card').append(basketItem);
  });

  // Обработчик удаления элемента из корзины
  $(document).on('click', '.delete', function() {
    $(this).closest('.basket').remove();
  });
});
