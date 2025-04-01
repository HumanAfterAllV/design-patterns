import { Bluetooth, HeadPhones, Speaker, Wifi } from "./Bridge";

const headphones = new HeadPhones(new Bluetooth());
const speaker = new Speaker(new Wifi());

headphones.playSound("Thrash Metal");
speaker.playSound("Enigma");
