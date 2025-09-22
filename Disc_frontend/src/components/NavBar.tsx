import { HStack, Image } from "@chakra-ui/react"
import logo from "../assets/DISC_wheel.png"
import { ColorModeSwitch } from "./ColorModeSwitch"

export const NavBar = () => {
  return (
  <HStack justifyContent="space-between" paddingRight={25}>
    <Image src={logo} boxSize="60px"/>
    <ColorModeSwitch/>
  </HStack>
  )
}


