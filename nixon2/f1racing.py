#1 import library
import pygame
from pygame.locals import *
#2initialize the game
pygame.init()
width,height=1083,493 
screen=pygame.display.set_mode((width,height))
#3load game
player=pygame.image.load("resources/carp.png")
road=pygame.image.load("resources/road.png")
#4keep looping through
running=1
exitcode=0
while running:
    #5clear the screen before drawing it again
    screen.fill(0)
    #6draw the player on the screen at x:100 y:100
    screen.blit(road,(0,0))
    screen.blit(player,(425,186))
    #7 update the screen
    pygame.display.flip()
    #8 loop through the events
    for event in pygame.event.get():
        # check if the event is the x button
        if event.type==pygame.QUIT:
            #if it is quit the game
            pygame.quit()
            exit(0)
    
    
