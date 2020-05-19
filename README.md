# USB-Interface

Communication via USB is the most popular mode of interfacing nowadays. Almost all the peripherals that have other kind of interfacing (serial port, parallel port..) are converting the ports to be compatible with USB. Building a general USB interface that can later be extended to industrial components handling is of major concern. Because of this reason leaders in microcontroller designing have explicitly designed microchips that can support USB protocol. This attempt is to program one such microchip to build a general I/O board. The board will be hereafter referred as the GIOB. GIOB has the following features. 

- can read 16 input lines 
- can write to 8 output lines 
- no external power supply required, power is supplied via the PC’s USB bus 
- compatible with USB 2.0, 3.0

To design GIOB we use the PIC18F4550 USB module which is a 8 bit PIC microcontroller. We chose this module as it has a stable clock for full-speed USB operation and is widely used for USB communication. Also the designer of this microcontroller, MICROCHIP has provided the tools to program the IC. Since this IC is the widely used component in this field there is an active supportive community. 


To start with the project, we are going to refer ​USB interface to the PIC Microcontroller  Then, extend the design and the concept to more generalized plug and play I/O interface with maximum data lines possible.

More infomation can be found on the documentation.
