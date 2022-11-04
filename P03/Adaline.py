from operator import length_hint
import matplotlib, numpy as np, sys
import copy

class Adaline:

  def __init__(self,num_N,learnignRate):
    self.w=np.random.rand(num_N)
    self.b=np.random.rand()
    self.eta=learnignRate
    self.error=0
    self.fv=1
    self.lenght=num_N-1
    self.nuevaY=[]
    self.puntos=[]
    #self.w=[0.2,0.2,0.2]
    #self.b=0.2

  def start(self,signal):
    self.puntos=signal
    print(self.puntos)
    for x in range(3):
        self.nuevaY.append(self.puntos[x])
    print(f"El deseado al inicion es {self.nuevaY}")    
    #calcular la Y
    while self.lenght<9999:
      
      self.Calcular_error()
      self.Calcular_pesos()
      self.calcularY()
      self.lenght=self.lenght+1

    #self.print()
  def calcularY(self):
    #print("Calcular y")
    f1=self.b*1
    f2=self.nuevaY[self.lenght-2]*self.w[0]
    f3=self.nuevaY[self.lenght-1]*self.w[1]
    f4=self.nuevaY[self.lenght-0]*self.w[2]
    suma=f1+f2+f3+f4
    #print(f"la nueva y es y es  {suma}")
    self.nuevaY.append(round(suma,4))
    deseado=self.getDeseado()
    #print(f"El valor deseado es {deseado}")
    resultado=deseado-suma
    #print(f"El resultado es {resultado}")
    self.error=(round(resultado,4))



  def Calcular_pesos(self):
    #print("Calcular los pesos")
    f1=self.b +(self.eta*self.error*1)     
    f2=self.w[0]+(self.eta*self.error*self.nuevaY[self.lenght-2])
    f3=self.w[1]+(self.eta*self.error*self.nuevaY[self.lenght-1])
    f4=self.w[2]+(self.eta*self.error*self.nuevaY[self.lenght])
    
    self.b=round(f1,4)
    self.w[0]=round(f2,4)
    self.w[1]=round(f3,4)
    self.w[2]=round(f4,4)
    #print(f"los nuevos pesos son {self.w}")
    #print(f"El nuevo b ahora es {self.b}")

  def Calcular_error(self):

    f1=self.b*1
    f2=self.nuevaY[self.lenght-2]*self.w[0]
    f3=self.nuevaY[self.lenght-1]*self.w[1]
    f4=self.nuevaY[self.lenght-0]*self.w[2]
    suma=f1+f2+f3+f4
    #print(f"Las suma es {suma}")
    deseado=self.getDeseado()
    #print(f"El valor deseado es {deseado}")
    resultado=deseado-suma
    #print(f"El resultado es {resultado}")
    self.error=(round(resultado,4))
    

  def getDeseado(self):
    numero=len(self.puntos)
    if(self.lenght<numero-1):
      #print("entra al if")
      return self.puntos[self.lenght+1]
    else:
      #print("entra al else")
      return self.puntos[numero-1]
        
    
  def print(self):
    print(f"las w{self.w}")
    print(f"Valor de Eta {self.eta}")
    print(f"valor del error {self.error}")
    #print(f"Valor de f(v) {self.fv}")
    print(f"Valor nuevaY{self.nuevaY}")
    print(f"El valor de b es {round(self.b, 2)}")
    print(f"El valor de lenght es {self.lenght}")
  def getNuevaY(self):
    #print(f"El valor de la nueva cadena es {len(self.nuevaY)}")
    return self.nuevaY
