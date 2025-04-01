from bridge import Bluetooth, Wifi, Cable, Headphones, Speaker

def main():
    headphones = Headphones(Bluetooth())
    speaker = Speaker(Wifi())

    headphones.play_sound("Lo-fi beats")
    speaker.play_sound("Synthwave blast")

if __name__ == "__main__":
    main()
