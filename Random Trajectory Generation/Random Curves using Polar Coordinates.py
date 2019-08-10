
# coding: utf-8

# ## Import

# In[122]:


import numpy as np 
import seaborn as sns 
import matplotlib.pyplot as plt
from math import *
from random import randrange
import matplotlib.pylab as pl


# ## Prototyping Curve Generation

# In[130]:


res_r = 0.1
res_th = 10

r = np.arange(5, 10, res_r)
th = np.arange(0, 2 * pi, pi / (res_th / 2) )

for th_i in th:
    x, y = [r_i * np.cos(th_i) for r_i in r], [r_i * np.sin(th_i) for r_i in r] 


# In[131]:


n_plots = 3

fig, axs = plt.subplots(n_plots)
fig.set_size_inches(10, 10)



limits = [2,8]
n = 5
colors = pl.cm.spring(np.linspace(0,1,n))

for i in range(n_plots): 
    
    x, y = [], []

    a, b = randrange(limits[0], limits[1]),             randrange(limits[0], limits[1])

    for theta in np.arange(0, 2 * pi, pi / 100):
        r =  2 * sqrt(a + cos(b*theta)**2)
        x.append(r * cos(theta))
        y.append(r * sin(theta))
    axs[i].plot(x, y, '-', linewidth = 3, color=colors[i])
    axs[i].axis('off')
    

plt.show()

