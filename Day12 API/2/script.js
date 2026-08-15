const accessToken = 'eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJhODQ0MWU4ZjE0MzMxYzQ0Yjg3YTA3MDE2YTRhMWI2YSIsIm5iZiI6MTc4NjM1NTYwMC4wMDE5OTk5LCJzdWIiOiI2YTc5OWY4Zjc5ZmUyZmViYTNmNTc5NzIiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.8TTGo9fnEit944Iuf09vYBFaF0kEBGOphrccQDr_Obo';

async function getMovieData(movieId) {
  const url = `https://api.themoviedb.org/3/movie/${movieId}?language=en-US`;
  
  const options = {
    method: 'GET',
    headers: {
      accept: 'application/json',
      Authorization: `Bearer ${accessToken}`
    }
  };

  try {
    const response = await fetch(url, options);
    const data = await response.json();
    return data;
  } catch (error) {
    console.error(error);
  }
}

async function displayMovie(movieId) {
  const main = document.getElementById('main-content');
  const movie = await getMovieData(movieId);

  if (!movie) {
    main.innerHTML = '<p>Error fetching data.</p>';
    return;
  }

  const genresHTML = movie.genres.map(g => `<span class="genre-badge">${g.name}</span>`).join('');
  const posterURL = movie.poster_path 
    ? `https://image.tmdb.org/t/p/w500${movie.poster_path}` 
    : 'https://via.placeholder.com/500x750?text=No+Image';

  main.innerHTML += `
    <div class="movie-card">
      <img class="movie-poster" src="${posterURL}" alt="${movie.title}">
      <div class="movie-details">
        <h2>${movie.title} (${movie.release_date ? movie.release_date.split('-')[0] : 'N/A'})</h2>
        ${movie.tagline ? `<p class="tagline">"${movie.tagline}"</p>` : ''}
        <div class="genres">${genresHTML}</div>
        <h3>Overview</h3>
        <p>${movie.overview || 'No overview available.'}</p>
        
        
        <div class="info-grid">
          <div class="info-item">
            <h4>Rating</h4>
            <p>⭐ ${movie.vote_average.toFixed(1)} / 10</p>
          </div>
          <div class="info-item">
            <h4>Release Date</h4>
            <p>${movie.release_date || 'N/A'}</p>
          </div>
          <div class="info-item">
            <h4>Runtime</h4>
            <p>${movie.runtime ? movie.runtime + ' mins' : 'N/A'}</p>
          </div>
          <div class="info-item">
            <h4>Budget</h4>
            <p>${movie.budget ? '$' + movie.budget.toLocaleString() : 'N/A'}</p>
          </div>
          <div class="info-item">
            <h4>Revenue</h4>
            <p>${movie.revenue ? '$' + movie.revenue.toLocaleString() : 'N/A'}</p>
          </div>
          <div class="info-item">
            <h4>Status</h4>
            <p>${movie.status}</p>
          </div>
        </div>
      </div>
    </div>
  `;
}

displayMovie(299536);
displayMovie(1311031);
displayMovie(1083381);
displayMovie(1439930);
