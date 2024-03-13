<?php

/* https://api.telegram.org/bot1746423999:AAEeAzdQy03mZ8tl5szt9rRgvOFUo_hxDa4/getUpdates,
где, XXXXXXXXXXXXXXXXXXXXXXX - токен вашего бота, полученный ранее */

$name = $_POST['user_name'];
$message = $_POST['user_message'];
$email = $_POST['user_email'];
$token = "1712788571:AAFGX4T5Wd0dX_uVIhw2COBWIZavuZa6-jc";
$chat_id = "-563994814";
$arr = array(
  'Имя пользователя: ' => $name,
  'сообщения ' => $message,
  'Email' => $email
);

foreach($arr as $key => $value) {
  $txt .= "<b>".$key."</b> ".$value."%0A";
};

$sendToTelegram = fopen("https://api.telegram.org/bot{$token}/sendMessage?chat_id={$chat_id}&parse_mode=html&text={$txt}","r");

if ($sendToTelegram) {
  header('Location: index.html');
} else {
  echo "Error";
}
?>
