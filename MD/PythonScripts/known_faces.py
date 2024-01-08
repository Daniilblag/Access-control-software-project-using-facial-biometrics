import dlib
import numpy as np

# Загрузка предобученной модели распознавания лиц
detector = dlib.get_frontal_face_detector()
predictor = dlib.shape_predictor('path/to/shape_predictor_68_face_landmarks.dat')

# Функция для извлечения лицевых особенностей из изображения лица
def extract_face_features(image_path):
    img = dlib.load_rgb_image(image_path)
    faces = detector(img)

    if len(faces) > 0:
        shape = predictor(img, faces[0])
        face_descriptor = face_rec_model.compute_face_descriptor(img, shape)
        return np.array(face_descriptor)

    return None

# Путь к изображениям лиц для пополнения known_faces
images_to_add = ['C:/Users/Даниил/Desktop/MD/MD/Database/image1.jpg']

# Пополнение known_faces с использованием извлеченных лицевых особенностей
known_faces = []
for image_path in images_to_add:
    face_features = extract_face_features(image_path)
    if face_features is not None:
        known_faces.append(face_features)

# Вывод обновленного списка known_faces
print(known_faces)