#import face_recognition
import numpy
import cv2
import os

haarcascade = 'haarcascade_frontalface_default.xml'

def detect_face(img):
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    resized_grey = cv2.resize(gray, (640, 480))
    face_cascade = cv2.CascadeClassifier(haarcascade)
    faces = face_cascade.detectMultiScale(resized_grey, 1.3, 5)

    if (len(faces) == 0):
        return None, None

    (x, y, w, h) = faces[0]
    return resized_grey[y:y+w, x:x+h], faces[0]

def loadTrainedFaces():
    dirs = os.listdir('./trained_faces')
    faces = []
    labels = []
    names = []
    
    currentLoadedLabel = 0

    for dir_name in dirs:
        images = os.listdir('./trained_faces/' + dir_name)
        for image_name in images:
            print('./trained_faces/' + dir_name + '/' + image_name)
            print(currentLoadedLabel)
            image = cv2.imread('./trained_faces/' + dir_name + '/' + image_name)
            resized_image = cv2.resize(image, (640, 480)) 
            face, rectangle = detect_face(resized_image)
            faces.append(face)
            labels.append(currentLoadedLabel)
            names.append(dir_name)

        currentLoadedLabel += 1

    return faces, labels, names


trained_faces, labels, names = loadTrainedFaces()

face_recognizer = cv2.face.LBPHFaceRecognizer_create()
#or use EigenFaceRecognizer by replacing above line with
#face_recognizer = cv2.face.EigenFaceRecognizer_create()
 
#or use FisherFaceRecognizer by replacing above line with 
#face_recognizer = cv2.face.createFisherFaceRecognizer()

face_cascade = cv2.CascadeClassifier(haarcascade)
face_recognizer.train(trained_faces, numpy.array(labels))
camera = cv2.VideoCapture(0)

while True:
    ret, frame = camera.read()
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    faces = face_cascade.detectMultiScale(gray, 1.3, 5)

    if len(faces) > 0:
        prediction_label = face_recognizer.predict(gray)
        print(prediction_label)

    cv2.imshow("test", frame)
    cv2.waitKey(30)

camera.release