document.addEventListener('DOMContentLoaded', function() {
    const slider = document.getElementById('modeSlider');
    const section = document.querySelector('.light-dark-section'); // Targeting the section directly
    const container = document.querySelector('.light-dark-section .container');
    const heading = container.querySelector('.slider-content h2'); // Targeting h2 within slider-content
    let isDragging = false;

    slider.addEventListener('mousedown', function(event) {
        isDragging = true;
        slider.style.cursor = 'grabbing';
    });

    document.addEventListener('mousemove', function(event) {
        if (isDragging) {
            const containerRect = container.getBoundingClientRect(); // Using container's bounding client rectangle
            let offsetX = event.clientX - containerRect.left; // Adjusting offsetX based on container's left position
            const sliderWidth = container.offsetWidth; // Using container's width
            
            if (offsetX < 0) offsetX = 0;
            if (offsetX > sliderWidth) offsetX = sliderWidth;
            
            const positionPercentage = offsetX / sliderWidth;

            if (positionPercentage < 0.5) {
                section.style.transition = 'background-color 0.3s ease, color 0.3s ease'; // Add transition effect
                section.style.backgroundColor = '#0B0F19'; // Set background color to dark instantly
                heading.style.color = 'white'; // Set heading color to white
            } else {
                section.style.transition = 'background-color 0.3s ease, color 0.3s ease'; // Add transition effect
                section.style.backgroundColor = 'white'; // Set background color to light instantly
                heading.style.color = 'black'; // Set heading color to black
            }

            // Update slider position
            slider.style.left = `${offsetX - slider.offsetWidth / 2}px`;
        }
    });

    document.addEventListener('mouseup', function() {
        isDragging = false;
        slider.style.cursor = 'grab';
    });
});





