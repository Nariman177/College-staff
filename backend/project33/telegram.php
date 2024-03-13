<?php

/* https://api.telegram.org/bot5744057090:AAHfZvmwBQuJite_9li6ugzRxQnn3UPeu_Y/getUpdates,
где, XXXXXXXXXXXXXXXXXXXXXXX - токен вашего бота, полученный ранее */

$name = $_POST['user_name'];
$message = $_POST['user_message'];
$email = $_POST['user_email'];
$token = "5731122093:AAGY5OEvMUujoW8cB-hC5JqYIfRFRs7wmck";
$chat_id = "-864942787";
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
