using Bridge;

var phones = new HeadPhones(new Bluetooth());
var speaker = new Speaker(new Wifi());

phones.PlaySound("Trash Metal");
speaker.PlaySound("Enigma");