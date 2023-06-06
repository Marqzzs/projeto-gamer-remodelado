# # orcamento = 1000
# # valorGasto = 200
# # pct = (valorGasto/orcamento)
# # print(f'A porcentagem do valor gasto é: {pct:.2%}')

# # idade = input("Digite sua idade: ")
# # idade_num = int(idade)
# # if idade_num >= 18:
# #     print('Da pra dirigir já em')
# # idade = input('Digite sua idade: ')
# # idade_num = int(idade)
# # tempo_contrib = 20

# # if idade_num >= 65 or tempo_contrib >= 35:
# #     print('Habilitado para solicitar aposentadoria!')
# # else:
# #     print('Espera mais ou trabalhe mais ☺')

# import pygame

# # Initialize Pygame
# pygame.init()

# # Set the size of the window
# size = (800, 700)

# # Create a new Pygame window
# screen = pygame.display.set_mode(size)

# pygame.display.set_caption("lobipidao")

# # Load the image file
# image = pygame.image.load("lobipidao.png")

# # Get the size of the image
# image_size = image.get_size()

# # Calculate the center of the screen
# center = (size[0] / 2 - image_size[0] / 2, size[1] / 2 - image_size[1] / 2)

# # Fill the screen with the image
# screen.blit(image, center)

# # Update the display
# pygame.display.flip()

# # Load the icon file
# icon = pygame.image.load("lobipidao.png")

# # Set the icon
# pygame.display.set_icon(icon)

# # Loop until the user clicks the close button
# done = False
# while not done:

#     # Check for events
#     for event in pygame.event.get():
#         if event.type == pygame.QUIT:
#             done = True

# # Quit Pygame
# # pygame.quit()

# x = 10
# print('Valor:', x, '--', type(x))
# # atribuição do valor None à variável x
# x = None
# print('Valor:', x, '--', type(x))

print(str(None))
print(bool(None))