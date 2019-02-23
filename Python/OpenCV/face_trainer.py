#import face_recognition
import numpy
import cv2
import os
import sys

name = sys.argv[1]

dl_path = './trained_faces/' + name

if not os.path.exists(dl_path):
    os.makedirs(dl_path)

face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
camera = cv2.VideoCapture(0)

count = 0

while count < 12:
    ret, frame = camera.read()
    backingFrame = frame
    resized_frame = cv2.resize(frame, (640, 480))
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, 1.3, 5)
    for (x,y,w,h) in faces:
        cv2.rectangle(frame,(x,y),(x+w,y+h),(255,0,0),2)
        roi_gray = gray[y:y+h, x:x+w]
        roi_color = frame[y:y+h, x:x+w]

    cv2.imshow("test", frame)
    key = cv2.waitKey(30)
    if key == 32 and len(faces) > 0:
        path = './trained_faces/' + name + '/' + str(count) + '.jpg'
        cv2.imwrite(path, gray)
        count += 1

camera.release