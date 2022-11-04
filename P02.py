from logging import exception
from tkinter import ttk, messagebox
import matplotlib, numpy as np, sys
matplotlib.use('TkAgg')
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg
from matplotlib.backend_bases import MouseButton
from matplotlib.figure import Figure
import tkinter as Tk

class Perceptron:
    def __init__(self,learnignRange):
        self.w=-1 + 2 * np.random.rand(2)
        self.b=-1 + 2 * np.random.rand()
        self.eta=learnignRange
    def printV(self):
        print(self.w)
        print(self.b)
        print(self.eta)

    def printline(self,last):

        #print("inicilzaizar")
        global ax, f
        w1, w2, b = self.w[0], self.w[1], self.b
        li, ls = -4, 4
        linestyle = '-r'
        if last == True:
            linestyle = '-g'
        ax.plot([li,ls],
        [(1/w2)*(-w1*(li)-b),(1/w2)*(-w1*(ls)-b)],
        linestyle)
        f.canvas.draw()
        f.canvas.flush_events()

    def fit(self,X,Y,maxIteration):
        global end_C, iteraciones, lastPred
        print("dentro de fit queremos ver b")
        print(self.b)
        print ("valores de w")
        print(self.w)
        p = X.shape[1]
        prediction = np.zeros(p)
        end_C = False
        for current in range(maxIteration):
            for i in range(p):
                estado_y = self.predict(X[:,i].reshape(-1,1))
                self.w += self.eta * (Y[i]-estado_y) * X[:,i]#formula para calcular los nuevos pesos
                self.b += self.eta * (Y[i]-estado_y)
                prediction[i] = estado_y
                #print(X[:,i].reshape(-1,1))
                #print("print valores de y"+str(y_est))
                #print("deseado "+str(deseado[i]))
            iteraciones = current
            lastPred = prediction.tolist()
            if (np.array_equal(Y, prediction)) == True:
                self.printline(True)
                end_C = True
                break
            else:
                self.printline(False)
                 

    def predict(self, X):
            p = X.shape[1]
            estado_y = np.zeros(p)
            for i in range(p):
                estado_y[i] = np.dot(self.w, X[:,i]) + self.b
                if estado_y[i] >= 0:
                    estado_y[i] = 1
                else:
                    estado_y[i] = 0
            return estado_y




lastPred = []
pointsX = []
pointsY = []
deseado = []
iteraciones=0
end_C=False


def Trainer_Evenet():
    #print("hola")
    global entryMI,entryLR, end_C, iteraciones
    maxIteration=int(entryMI.get())
    learningRate=float(entryLR.get())
    if maxIteration <=0:
        print("No hay iteraciones")
        return
    if len(pointsX) == 0:
        print("No hay puntos en la grafica")
        return
    X = np.array ([
        pointsX,
        pointsY]) # INPUTS
    Y = np.array(deseado)
    print(X.shape, Y.shape)
    neurona.fit(X,Y,maxIteration)


def Start_Event():
    global ax, f, neurona,entryLR
    learningRange=0

    try:
        learningRange=float(entryLR.get())
        #print(learningRange)
        neurona=Perceptron(learningRange)
        ax.cla()
        ax.grid('on')
        ax.set_xlim([-4,4])
        ax.set_ylim([-4,4])
        X = np.array ([
            pointsX,
            pointsY]) # INPUTS
        Y = np.array(deseado)
        t, p = X.shape
        #print("pasa 1")
        for i in range(p):
            if Y[i] == 0:
                ax.plot(X[0,i],X[1,i], '.r')
            else:
                ax.plot(X[0,i],X[1,i], '.b')
        neurona.printline(False)
        f.canvas.draw()
    except:
        print("ingrese datos validos")
        
    
def Canvas_Event(event):
    x= event.xdata#get x
    y=event.ydata#get y
    global ax, f#global variables
    color=""
    if x is not None or y is not None:
        if(event.button is MouseButton.LEFT ):
            color='.r'
            print('Clicked canvas: ', x, y,' color rojo')
            deseado.append(0)
        else:
            color='.b'
            print('Clicked canvas: ', x, y,' color azul')
            deseado.append(1)
        ax.plot(x,y, color)
        pointsX.append(x)
        pointsY.append(y)
        f.canvas.draw()
def clean_Event():
    global ax, f, neurona,entryLR
    learningRange=0
    ax.cla()
    ax.grid('on')
    ax.set_xlim([-4,4])
    ax.set_ylim([-4,4])
    X = np.array ([
        pointsX,
        pointsY]) # INPUTS
    Y = np.array(deseado)
    t, p = X.shape
    #print("pasa 1")
    for i in range(p):
        if Y[i] == 0:
            ax.plot(X[0,i],X[1,i], '.r')
        else:
            ax.plot(X[0,i],X[1,i], '.b')
    neurona.printline(True)
    f.canvas.draw()
def Reset_Event():
    global lastPred,pointsX,pointsY,deseado,iteraciones,end_C,f,ax
    lastPred.clear()
    pointsX.clear
    pointsY.clear()
    deseado.clear()
    iteraciones=0
    end_C=False
 
    ax.cla()
    ax.set_xlim([-4,4])
    ax.set_ylim([-4,4])
    f.canvas.draw()
 
    f.canvas.flush_events()
   
#Window
root = Tk.Tk()
root.geometry('900x600')
root.minsize(900, 800)
root.title('Practica 02')

#PLOT
f = Figure(figsize=(0,0), dpi=100)
ax = f.add_subplot(111)
f.canvas.callbacks.connect('button_press_event', Canvas_Event)
ax.grid('on')
ax.set_xlim([-4,4])
ax.set_ylim([-4,4])
canvas = FigureCanvasTkAgg(f, master=root)
canvas.get_tk_widget().place(relx=0.02, rely=0.02, relheight=.7, relwidth=0.7)

#Button

labelLR = ttk.Label(text='LEARNIGN RATE (0-1):', anchor='e')
labelLR.place(relx=0.75, rely=0.05, height=20, width=150)
entryLR=ttk.Entry()
entryLR.place(relx=0.75, rely=0.10, height=20, width=150)

labelMI =ttk.Label(text='Max Iteration: ',anchor='e')
labelMI.place(relx=0.75, rely=0.15, height=20, width=100)
entryMI=ttk.Entry()
entryMI.place(relx=0.75,rely=0.2,height=20,width=150)

buttonStart=ttk.Button(text='Start ',command=Start_Event)##falta comand
buttonStart.place(relx=0.75,rely=0.25,height=30,width=150)

buttonTrain= ttk.Button(text='Train', command=Trainer_Evenet)
buttonTrain.place(relx=0.75,rely=0.30, height=30,width=150)

buttonCheck=ttk.Button(text='Clean', command=clean_Event)
buttonCheck.place(relx=0.75,rely=0.35,height=30,width=150)

buttonCheck=ttk.Button(text='Reset', command=clean_Event)
buttonCheck.place(relx=0.75,rely=0.40,height=30,width=150)

neurona=Perceptron(0.1)

Tk.mainloop()