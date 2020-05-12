How to Run:
---------------------------------------------------
Install Open cv python on your machine using cmd
here's a link to a how to guide that helped me
https://pysource.com/2019/03/15/how-to-install-python-3-and-opencv-4-on-windows/
----------------------------------------------------------------------------------------------------------------------------------------
Download the Opencv binary files here: https://www.lfd.uci.edu/~gohlke/pythonlibs/#opencv

Choose the compatible version of Opencv to your Python. We’ll download the lastest version of Opencv (4.1) for Python 3.6.8.
How to understand the right version?
-cp37m-win32.whl means that Opencv is for python 3.7 (32 bit version)
-cp36m-win_amd64.whl means that Opencv is for python 3.6 (64 bit version)

Run the “Command Prompt” of Windows. You can type “CMD” on the sarch bar to find it.

Go to the directory where the Opencv binaries that you downloaded is located.
cd YOURPATHfor example in my case:
cd C:\Users\pinolo\Downloads

Now let’s install the Opencv module using PIP.
python pip -m install opencv_python‑4.0.1+contrib‑cp37‑cp36m‑win_amd64.whl

Now let’s install Numpy using PIP.
python pip -m install numpy

The installation is complete. Now we can test it by running python and importing the libraries cv2 (for opencv) and numpy. If we don’t get any error it means that it has been installed succesfully.
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Setup before running the game. 
Open up command prompt and change directory to the python file in the folder, there should be facedetect.py in that folder

run the command "python facedetect.py" this should open a webcam window that tracks your face.

then run the exe In the EXE folder
and you should be good to go.


If you have any issues feel free to email u1759958@unimail.hud.ac.uk