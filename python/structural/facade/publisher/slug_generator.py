from re import sub

def slug_generator(title: str):
    
    if not title:
        raise ValueError("The title cannot be empty")

    title = title.lower().strip()
    title = sub(r'[^\w\s-]', '', title)
    title = sub(r'[\s_-]+', '-', title)
    title = sub(r'^-+|-+$', '', title)

    return title
