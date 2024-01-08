import cv2;
import dlib
from scipy.spatial import distance

def face_recognition():
    # Загрузка каскадного классификатора для распознавания лица
    face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')

    # Инициализация видеозахвата с помощью веб-камеры
    video_capture = cv2.VideoCapture(0)

    # Загрузка известных данных (изображений лиц для сравнения)
    known_faces = [...]  # Здесь должны быть загружены известные данные

    while True:
        # Захват видеокадра
        ret, frame = video_capture.read()

        # Преобразование в оттенки серого
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

        # Обнаружение лиц
        faces = face_cascade.detectMultiScale(gray, scaleFactor=1.1, minNeighbors=5, minSize=(30, 30))

        result = False

        # Отображение прямоугольников вокруг лиц и проверка на аутентификацию
        for (x, y, w, h) in faces:
            # Извлечение области лица для сравнения
            face_roi = gray[y:y+h, x:x+w]

            result = authenticate(face_roi, known_faces)
           
            # Отображение прямоугольника вокруг лица
            cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)

        # Отображение кадра
        cv2.imshow('Face Recognition', frame)

        # Выход из цикла по нажатию клавиши 'q'
        if cv2.waitKey(1) & 0xFF == ord('q') or result == False:
            return False
            break 
        else:
            return True
            break 

    # Освобождение ресурсов
    video_capture.release()
    cv2.destroyAllWindows()


def authenticate(face_roi, known_faces):
    # Проход по всем известным лицам
    for known_face in known_faces:
        if compare_faces(face_roi, known_face):
            return True  # Аутентификация успешна

    return False  # Аутентификация не удалась
  
def compare_faces(face1, face2):
    # Создание экземпляра детектора лиц dlib
    face_detector = dlib.get_frontal_face_detector()

    # Создание экземпляра предобученной модели распознавания лиц dlib
    shape_predictor = dlib.shape_predictor('shape_predictor_68_face_landmarks.dat')

    # Создание экземпляра предобученной модели извлечения лицевых особенностей dlib
    face_recognizer = dlib.face_recognition_model_v1('dlib_face_recognition_resnet_model_v1.dat')

    # Детектирование лиц на изображениях
    face1_detections = face_detector(face1)
    face2_detections = face_detector(face2)

    # Извлечение лицевых особенностей для обоих лиц
    face1_landmarks = shape_predictor(face1, face1_detections[0])
    face1_descriptor = face_recognizer.compute_face_descriptor(face1, face1_landmarks)

    face2_landmarks = shape_predictor(face2, face2_detections[0])
    face2_descriptor = face_recognizer.compute_face_descriptor(face2, face2_landmarks)

    # Расчет расстояния между лицевыми особенностями с использованием евклидова расстояния
    face_distance = distance.euclidean(face1_descriptor, face2_descriptor)

    # Установка порогового значения для определения совпадения лиц
    threshold = 0.6

    if face_distance <= threshold:
        return True  # Лица совпадают
    else:
        return False  # Лица не совпадают