
import matplotlib.pyplot as plt
from numpy import pi,sin,linspace
import random
from Adaline import *


if __name__ == '__main__':
  
  amplitud = 2.0
  frecuencia = 0.01

  t1 = linspace(0,2, 10000)
  f1 = amplitud * (sin(100*frecuencia * pi * t1))
  ruido=[]
  ruido_final=[]
  for x in f1:
    ruido.append(x+random.uniform(-0.5,0.5))
  for x in ruido:
    ruido_final.append(round(x,4))
 # print(ruido_final)



  adaline=Adaline(3,0.02)
  adaline.start(ruido_final)
  resultado=adaline.getNuevaY()
  #nueva_y=adaline.getDeseado()
  plot1 = plt.figure(1)
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")
  plt.plot(t1,ruido,color="blue")
  plt.plot(t1,resultado,color="red")
  plt.plot(t1, f1, color="black")
  
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")



  amplitud = 2.0
  frecuencia = 0.05
  t2 = linspace(0,5, 10000)
  f2 = amplitud * (sin(100*frecuencia * pi * t1))
  ruido=[]
  ruido_final=[]
  for x in f2:
    ruido.append(x+random.uniform(-0.5,0.5))
  for x in ruido:
    ruido_final.append(round(x,4))
  #print(ruido_final)

  adaline2=Adaline(3,0.01)
  adaline2.start(ruido_final)
  resultado=adaline2.getNuevaY()
  plot2 = plt.figure(2)
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")
  plt.plot(t2,ruido,color="blue")
  plt.plot(t2,resultado,color="red")
  plt.plot(t2, f2, color="black")
  
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")




  amplitud = 1.0
  frecuencia = 0.03
  t3 = linspace(0,2, 10000)
  f3 = amplitud * (sin(100*frecuencia * pi * t1))
  ruido=[]
  ruido_final=[]
  for x in f3:
    ruido.append(x+random.uniform(-0.5,0.5))
  for x in ruido:
    ruido_final.append(round(x,4))
  #print(ruido_final)

  adaline3=Adaline(3,0.005)
  adaline3.start(ruido_final)
  resultado=adaline3.getNuevaY()
  plot3 = plt.figure(3)
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")
  plt.plot(t3,ruido,color="blue")
  plt.plot(t3,resultado,color="red")
  plt.plot(t3, f3, color="black")
  
  plt.grid(True)
  plt.xlabel("Tiempo")
  plt.ylabel("Amplitud")




  plt.show()