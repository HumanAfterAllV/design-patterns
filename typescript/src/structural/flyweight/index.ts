import { IconFactory } from "./map/IconFactory";
import { MapLocation } from "./map/Location";

const factory = IconFactory.getInstance()

const hospitalIcon = factory.getIcon("Hospital")
const hospitalIcon2 = factory.getIcon("Hospital")
const schoolIcon = factory.getIcon("School")

const locationOne = new MapLocation(19.4, -99.1, hospitalIcon, "Hospital Central");
const locationTwo = new MapLocation(20.4, 50.1, hospitalIcon2, "Hospital Central");
const locationThree = new MapLocation(45.5, 150.88, schoolIcon, "Hospital Central");


locationOne.draw()
locationTwo.draw()
locationThree.draw()